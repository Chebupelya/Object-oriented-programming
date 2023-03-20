using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class ProcessorValidationAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            if (value != null)
            {
                string model = value.ToString();
                if (new Regex(@"^\w$").IsMatch(model))
                    ErrorMessage = "Неверный формат.";
                else
                    return true;
            }
            return false;
        }
    }
}
