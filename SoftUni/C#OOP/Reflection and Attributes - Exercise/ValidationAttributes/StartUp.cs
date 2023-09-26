using System;
using ValidationAttributes.Models;
using ValidationAttributes.Utilities;

namespace ValidationAttributes
{
    public class StartUp
    {
        public static void Main()
        {
           var person = new Person
            (
                "Ivan Ivanov",
                30
            );

            bool isValidEntity = Validator.IsValid(person);

            Console.WriteLine(isValidEntity);
        }
    }
}
