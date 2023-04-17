using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Smartproduct.Model.Category
{
    public static class CategoryValidator
    {
        public static bool IsValidCategoryCode(this string str)
        {
            return Regex.IsMatch(str, @"^[a-zA-Z]{3}[0-9]{3}$");
        }
    }
}
