using PizzaCalories.Exeptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaCalories.Models.SubModels
{
    public class Dough
    {
        private string flourType;
        private string bakingTechnique;
        private double weight;

        private List<string> possibleFlourType = new List<string>
        { "white", "wholegrain"};

        private List<string> possibleTechniqueType = new List<string>
        { "crispy", "chewy", "homemade"};

        public Dough(string flourType, string bakingTechnique, double weight)
        {
            this.FlourType = flourType;
            this.BakingTechnique = bakingTechnique;
            this.Weight = weight;
            this.GetCalories();
        }

        public string FlourType
        {
            get => this.flourType;
            private set
            {
                if (possibleFlourType.Contains(value) == false)
                {
                    throw new ArgumentException(Exeptions.Exeptions.InvalidTypeExeption);
                }

                this.flourType = value;
            }
        }

        public string BakingTechnique
        {
            get => this.bakingTechnique;
            private set
            {
                if (possibleTechniqueType.Contains(value) == false)
                {
                    throw new ArgumentException(Exeptions.Exeptions.InvalidTypeExeption);
                }

                this.bakingTechnique = value;
            }
        }

        public double Weight
        {
            get => this.weight;
            private set
            {
                if (value < Constants.Consts.WEIGHT_MIN_VALUE ||
                    value > Constants.Consts.DOUGH_WEIGHT_MAX_VALUE)
                {
                    throw new ArgumentException(Exeptions.Exeptions.DoughWeightExeption);
                }

                this.weight = value;
            }
        }

        public double GetCalories()
        {
            var calories = 1d;

            switch (this.FlourType)
            {
                case "white": calories *= 1.5; break;
                case "wholegrain": calories *= 1; break;
            }

            switch (this.BakingTechnique)
            {
                case "crispy": calories *= 0.9; break;
                case "chewy": calories *= 1.1; break;
                case "homemade": calories *= 1; break;
            }

            var result = 2 * this.weight * calories;

            return result;
        }
    }
}
