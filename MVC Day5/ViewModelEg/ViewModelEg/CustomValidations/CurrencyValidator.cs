using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ViewModelEg.CustomValidations
{
    public class CurrencyValidator : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            if(value==null)
            {
                return true;
            }
            float getsal;
            if(float.TryParse(value.ToString(),out getsal))
            {
                if (getsal == 0)
                {
                    return true;
                }
                if (getsal > 0)
                {
                    return true;
                }
               
                    
                }
            return false;
        }
        }
    }
