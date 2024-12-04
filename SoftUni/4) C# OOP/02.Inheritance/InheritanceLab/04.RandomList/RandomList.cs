namespace _04.RandomList
{
    public class RandomList : List<string>
    {
        public string RandomString()
        {
            var random = new Random();
            var randomNumber = random.Next(0, this.Count);

            var randomElement = this[randomNumber];

            this.RemoveAt(randomNumber);
            return randomElement;
        }
    }
}
