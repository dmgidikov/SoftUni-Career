using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WildFarm.Models.Food.Contracts;

namespace WildFarm.Models.Animals.Contracts
{
    public  interface IAnimal
    {
        string Name { get; }    

        double Weight { get; }

        int FoodEaten { get; }

        string ProduceSound();

        void Feed(IFood food);
    }
}
