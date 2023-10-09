namespace Façade
{
    public class StartUp
    {
        public static void Main()
        {
            var car = new CarBuilderFacade()
                .Info
                .WithType("BMW")
                .WithColor("Black")
                .WithNumberOfDoors(4)
                .Buil
                .InCity("Leipzig")
                .AtAddress("SomeAddress")
                .Build();

            Console.WriteLine(car);
        }
    }
}