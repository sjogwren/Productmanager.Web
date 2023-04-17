using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smartproduct.Model.Category
{
    [Table("Category")]
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string CategoryCode { get; set; }
        [Required]
        public bool IsActive { get; set; }
        [Required]
        public DateTime CreatedOn { get; set; }
        [Required]
        public string CreatedBy { get; set; }

        public string Errormessage1 { get; set; } = string.Empty;
        public string Errormessage2 { get; set; } = string.Empty;
        public string Errormessage3 { get; set; } = string.Empty;
    }
}
