using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Stealer
{
    public class Tracker
    {
        public void PrintMethodsByAuthor()
        {
            var type = typeof(StartUp);

            var methods = type.GetMethods
                ( BindingFlags.Public
                | BindingFlags.Static
                | BindingFlags.Instance);

            foreach (var method in methods)
            {
                if (method.CustomAttributes.Any(x => x.AttributeType == typeof(AuthorAttribute)))
                {
                    var attributes = method.GetCustomAttributes(false);

                    foreach (AuthorAttribute item in attributes)
                    {
                        Console.WriteLine($"{method.Name} is written by {item.Name}");
                    }
                }
            }
        }
    }
}
