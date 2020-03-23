using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;
using Unity.Injection;

namespace UnitySample
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = new UnityContainer();

            container.RegisterType<ICreditcard, Mastercard>();
            //container.RegisterType<ICreditcard, Mastercard>(new InjectionProperty("ChargCount", 5));

            var shopper=container.Resolve<Shopper>();
            shopper.Charge();
            Console.Read();
        }
    }
}
