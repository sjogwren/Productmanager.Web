using ClosedXML.Excel;
using Microsoft.AspNetCore.Http;
using Smartproduct.Interface.File;
using Smartproduct.Model.File;
using Smartproduct.Model.Product;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Smartproduct.Web.Models
{
    public static class FileHelper
    {
        public static Model.File.File AssignFile(IFormFile item, string username, int? productId)
        {
            string s = string.Empty;
            var file = new Model.File.File();
            using (var ms = new MemoryStream())
            {
                item.CopyTo(ms);
                var fileBytes = ms.ToArray();
                s = Convert.ToBase64String(fileBytes);

                file.ProductId = productId;
                file.FileName = item.FileName;
                file.FileData = Encoding.ASCII.GetBytes(s);
                file.FileContentType = item.ContentType;
                file.FileLength = Convert.ToInt32(item.Length);
                file.CreatedBy = username;
                file.CreatedOn = DateTime.Now;
            }
            return file;
        }

        public static List<Model.Product.Product> GetDataFromExcel(IFormFile File, List<Product> products, string username)
        {
            using (var workBook = new XLWorkbook(File.OpenReadStream()))
            {
                var workSheet = workBook.Worksheet(1);
                var firstRowUsed = workSheet.FirstRowUsed();
                var firstPossibleAddress = workSheet.Row(firstRowUsed.RowNumber()).FirstCell().Address;
                var lastPossibleAddress = workSheet.LastCellUsed().Address;

                // Get a range with the remainder of the worksheet data (the range used)
                var range = workSheet.Range(firstPossibleAddress, lastPossibleAddress).AsRange(); //.RangeUsed();
                                                                                                  // Treat the range as a table (to be able to use the column names)
                var table = range.AsTable();

                //Specify what are all the Columns you need to get from Excel
                var dataList = new List<string[]>
                 {
                     table.DataRange.Rows()
                         .Select(tableRow =>
                             tableRow.Field("Name")
                                 .GetString())
                         .ToArray(),
                     table.DataRange.Rows()
                         .Select(tableRow => tableRow.Field("Description").GetString())
                         .ToArray(),
                     table.DataRange.Rows()
                     .Select(tableRow => tableRow.Field("CategoryName").GetString())
                     .ToArray(),
                     table.DataRange.Rows()
                     .Select(tableRow => tableRow.Field("Price").GetString())
                     .ToArray()
                 };
                //Convert List to DataTable
                var dataTable = ConvertListToDataTable(dataList,products,username);
                //To get unique column values, to avoid duplication
                var uniqueCols = dataTable.DefaultView.ToTable(true, "Name");

                //Remove Empty Rows or any specify rows as per your requirement
                for (var i = uniqueCols.Rows.Count - 1; i >= 0; i--)
                {
                    var dr = uniqueCols.Rows[i];
                    if (dr != null)
                        dr.Delete();
                }

                var list = FileHelper.DataTableToList<ProductT>(dataTable);
                var productList = new List<Product>();
                foreach(var t in list)
                {
                    productList.Add(new Product()
                    {
                        ProductId = 0,
                        ProductCode = t.ProductCode,
                        Name = t.Name,
                        Description = t.Description,
                        CategoryName = t.CategoryName,
                        Price = t.Price,
                        Image = t.Image,
                        CreatedOn = t.CreatedOn,
                        CreatedBy = t.CreatedBy,
                        DeletedOn = t.DeletedOn,
                        DeletedBy = t.DeletedBy
                    });
                }
                return productList;
            }
        }

        public static List<T> DataTableToList<T>(DataTable table) where T : class, new()
        {
            try
            {
                T tempT = new T();
                var tType = tempT.GetType();
                List<T> list = new List<T>();
                foreach (var row in table.Rows.Cast<DataRow>())
                {
                    T obj = new T();
                    foreach (var prop in obj.GetType().GetProperties())
                    {
                        var propertyInfo = tType.GetProperty(prop.Name);
                        var rowValue = row[prop.Name];
                        var t = Nullable.GetUnderlyingType(propertyInfo.PropertyType) ?? propertyInfo.PropertyType;
                        object safeValue = (rowValue == null || DBNull.Value.Equals(rowValue)) ? null : Convert.ChangeType(rowValue, t);
                        propertyInfo.SetValue(obj, safeValue, null);
                    }
                    list.Add(obj);
                }
                return list;
            }
            catch(Exception r)
            {
                return null;
            }
        }

        private static DataTable ConvertListToDataTable(IReadOnlyList<string[]> list, List<Product> products, string username)
        {
            var table = new DataTable("CustomTable");
            var rows = list.Select(array => array.Length).Concat(new[] { 0 }).Max();
            var countProduct = products.Count();
            int counta = 0;

            table.Columns.Add("ProductId");
            table.Columns.Add("Name");
            table.Columns.Add("Description");
            table.Columns.Add("CategoryName");
            table.Columns.Add("Price");
            table.Columns.Add("Image");
            table.Columns.Add("ProductCode");
            table.Columns.Add("CreatedOn");
            table.Columns.Add("CreatedBy");
            table.Columns.Add("DeletedOn");
            table.Columns.Add("DeletedBy");



            for (var j = 0; j < rows; j++)
            {
                counta = countProduct + 1;
                var row = table.NewRow();
                row["Name"] = list[0][j];
                row["Description"] = list[1][j];
                row["CategoryName"] = list[2][j];
                row["Price"] = Convert.ToDecimal(list[3][j]);
                row["ProductCode"] = $"{DateTime.Now.ToString("yyyyMM") + "-0" + counta}";
                row["CreatedOn"] = DateTime.Now;
                row["CreatedBy"] = username;
                table.Rows.Add(row);
            }
            return table;
        }
    }
    public  class ProductT
    {
        public int ProductId { get; set; }
        public string ProductCode { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string CategoryName { get; set; }
        public decimal? Price { get; set; }
        public string Image { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? DeletedOn { get; set; }
        public string DeletedBy { get; set; }
    }
}
