﻿namespace Animals
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var cat = new Cat("Pesho", "Whiskas");
            var dog = new Dog("Gosho", "Meat");

            Console.WriteLine(cat.ExplainSelf());
            Console.WriteLine(dog.ExplainSelf());
        }
    }
}
