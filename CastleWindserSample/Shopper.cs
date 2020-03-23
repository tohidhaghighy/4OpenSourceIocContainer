using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CastleWindserSample
{
    public class Shopper
    {
        private readonly ICreditcard creditcard;
        public Shopper(ICreditcard creditcard)
        {
            this.creditcard = creditcard;
        }

        public void Charge()
        {
            var massage = creditcard.Sharg();
            Console.WriteLine(massage);
        }
    }
}
