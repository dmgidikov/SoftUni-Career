using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telephony
{
    public class Smartphone : ISmartphone, IStationaryPhone
    {
        public Smartphone(string phoneNumbers, string webAdresses) 
        {
            this.PhoneNumbers = phoneNumbers;
            this.WebAddreses = webAdresses;
        }

        public string PhoneNumbers { get; set; }

        public string WebAddreses { get; set; }

        public void Call()
        {
            var numbers = this.PhoneNumbers.Split(" ");
            GetNumbersData(numbers);
        }

        public void BrowseInIntertnet()
        {
            var adresses = this.WebAddreses.Split(" ");
            GetAddresesData(adresses);
        }

        private void GetNumbersData(string[] array)
        {
            foreach (var arrElement in array)
            {               
                if (arrElement.Length == 10)
                Console.WriteLine($"Calling... {arrElement}");

                if (arrElement.Length == 7)
                    Console.WriteLine($"Dialing... {arrElement}");
            }
        }

        private void GetAddresesData(string[] array)
        {
            foreach (var arrElement in array)
            {
                var containsDigit = CheckForDigits(arrElement);

                if (containsDigit == true)
                {
                    Console.WriteLine("Invalid URL!");
                }
                else
                {
                    Console.WriteLine($"Browsing: {arrElement}!");
                }
            }
        }

        private bool CheckForDigits(string element)
        {
            var containsDigit = false;

            for (int i = 0; i < element.Length; i++)
            {
                char ch = element[i];

                if (char.IsDigit(ch))
                {
                    containsDigit = true;
                    break;
                }
            }

            return containsDigit;
        }
    }
}
