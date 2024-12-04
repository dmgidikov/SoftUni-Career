namespace _01_RawData
{
    public class Engine
    {
        public Engine(int speed, int power) 
        {
            this.Speed = speed;
            this.Power = power;
        }

        public int Speed { get; }

        public int Power { get; }

        public override string ToString()
        {
            return $"{this.Speed} {this.Power}";
        }
    }
}