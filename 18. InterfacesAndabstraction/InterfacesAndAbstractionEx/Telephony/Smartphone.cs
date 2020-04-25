using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Telephony
{
    class Smartphone : ICalling,IBrowsing
    {

        public Smartphone(string[] numbers,string[] browsers)
        {
            this.Numbers = numbers;
            this.Brousers = browsers;
        }

        public string[] Numbers { get; }
        public string[] Brousers { get; }


        public string Browse(string url)
        {
            return url.Any(char.IsDigit) ? "Invalid URL!" : $"Browsing: {url}!";
        }

        public string Call(string number)
        {
            if (!number.All(char.IsDigit))
            {
                return "Invalid number!";
            }
            else if(number.Length<10)
            {
                return $"Dialing... {number}";
            }

            return $"Calling... {number}";
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            foreach (var number in Numbers)
            {
                sb.AppendLine(Call(number));
            }
            foreach (var url in Brousers)
            {
                sb.AppendLine(Browse(url));
            }
            return sb.ToString();
        }
    }
}