namespace _04.PizzaCalories.Ingredients
{
    public class Dough
    {
        private string _flourType;
        private string _bakingTechnique;
        private double _weight;

        private Dictionary<string, double> flourTypes = new Dictionary<string, double>
        {
            { "white" , 1.5 },
            { "wholegrain" , 1 }
        };

        private Dictionary<string, double> bakingTechniques = new Dictionary<string, double>
        {
            { "crispy", 0.9 },
            { "chewy", 1.1 },
            { "homemade", 1 }
        };

        public Dough(string flourType, string bakingTechnique, double weight)
        {
            this.FlourType = flourType;
            this.BakingTechnique = bakingTechnique;
            this.Weight = weight;
        }

        public string FlourType
        {
            get => _flourType;
            private set
            {
                if (flourTypes.ContainsKey(value) == false)
                {
                    throw new ArgumentException(
                        string.Format(Exceptions.Exception.InvalidTypeExeption,
                        nameof(this.FlourType)));
                }

                _flourType = value;
            }
        }

        public string BakingTechnique
        {
            get => _bakingTechnique;
            private set
            {
                if (bakingTechniques.ContainsKey(value) == false)
                {
                    throw new ArgumentException(
                       string.Format(Exceptions.Exception.InvalidTypeExeption,
                       nameof(this.BakingTechnique)));
                }

                _bakingTechnique = value;
            }
        }

        public double Weight
        {
            get => _weight;
            private set
            {
                if (value < Constants.Contstant.WEIGHT_MIN_VALUE ||
                   value > Constants.Contstant.DOUGH_WEIGHT_MAX_VALUE)
                {
                    throw new ArgumentException(Exceptions.Exception.WeightExeption);
                }

                _weight = value;
            }
        }

        public double GetCalories()
        {
            var modifier = 1 
                * flourTypes[FlourType]
                * bakingTechniques[BakingTechnique];

            var calories = 2 * modifier * _weight;

            return calories;
        }
    }
}