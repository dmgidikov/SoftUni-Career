﻿namespace WildFarm.Models.Foods
{
    using Contracts;

    public abstract class Food : IFood
    {
        protected Food(int quantity)
        {
            this.Quantity = quantity;
        }

        public int Quantity { get; protected set; }
    }
}