namespace _03.Telephony.Models
{
    using Contracts;

    public class StationaryPhone : IStationaryPhone
    {
        private string _number;

        public StationaryPhone()
        {
            Number = _number;
        }

        public string Number
        {
            get => _number;
            set => _number = value;
        }

        public string Call(string number)
        {
            if (number.All(ch => char.IsDigit(ch) == false))
            {
                throw new ArgumentException("Invalid number!");
            }
            return $"Dialing... {number}";
        }
    }
}