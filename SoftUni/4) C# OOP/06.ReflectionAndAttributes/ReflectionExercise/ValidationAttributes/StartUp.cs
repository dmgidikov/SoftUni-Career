namespace ValidationAttributes
{
    using Models;

    public class StartUp
    {
        public void Main()
        {
            var person = new Person
             (
                 null,
                 -1
             );

            bool isValidEntity = Validator.IsValid(person);

            Console.WriteLine(isValidEntity);
        }
    }
}