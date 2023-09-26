using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WildFarm.Models.Food.Contracts;

namespace WildFarm.Models.Food
{
    public abstract class Food : IFood
    {
        protected Food(int quatity) 
        {
            this.Quantity = quatity;
        }

        public int Quantity { get; private set; }
    }
}
