using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle.Windsor;
using Castle.MicroKernel.Registration;

namespace CastleWindserSample
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = new WindsorContainer();
            container.Register(Component.For<Shopper>());
            container.Register(Component.For<ICreditcard>().ImplementedBy<Mastercard>());

            var shoper = container.Resolve<Shopper>();
            shoper.Charge();
            Console.Read();
        }
    }
}
