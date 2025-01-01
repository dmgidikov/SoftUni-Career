namespace _03.Telephony.Models
{
    using Contracts;

    public class Smartphone : ISmartphone
    {
        private string _number;
        private string _site;

        public Smartphone()
        {
            Number = _number;
            Site = _site;
        }

        public string Number
        {
            get => _number;
            set => _number = value;
        }

        public string Site
        {
            get => _site;
            set => _site = value;
        }

        public string Call(string number)
        {
            if (number.All(ch => char.IsDigit(ch) == false))
            {
                throw new ArgumentException("Invalid number!");
            }
            return $"Calling... {number}";
        }

        public string Browse(string site)
        {
            if (site.Any(ch => char.IsNumber(ch)))
            {
                throw new ArgumentException("Invalid number!");
            }
            return $"Browsing... {site}";
        }
    }
}