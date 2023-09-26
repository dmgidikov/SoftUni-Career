using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using ValidationAttributes.Attributes;

namespace ValidationAttributes.Utilities
{
    public static class Validator
    {
        public static bool IsValid(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            var objtType = obj.GetType();

            var objectProprs = objtType.GetProperties();

            foreach ( var property in objectProprs)
            {
                var attributes = property
                    .GetCustomAttributes(true)
                    .Where(ca => ca is MyValidationAttribute)
                    .Cast<MyValidationAttribute>()
                    .ToArray();

                foreach (var attribute in attributes)
                {
                    if (attribute.IsValid(property.GetValue(obj)) == false)
                    {
                        return false;
                    }
                }               
            }

            return true;
        }
    }
}
