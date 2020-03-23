using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitySample
{
    public class Mastercard : ICreditcard
    {
        public string sharg()
        {
            ChargCount++;
            return "master card container";
        }
        public int ChargCount { get; set; }
    }
}
