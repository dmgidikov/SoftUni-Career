namespace AnimalFarm
{
    using System;
    using AnimalFarm.Models;
    public class StartUp
    {
        static void Main()
        {
            var name = Console.ReadLine();
            var age = int.Parse(Console.ReadLine());

            try
            {
                var chicken = new Chicken(name, age);

                Console.WriteLine(
                    "Chicken {0} (age {1}) can produce {2} eggs per day.",
                    chicken.Name,
                    chicken.Age,
                    chicken.ProductPerDay);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }            
        }
    }
}
