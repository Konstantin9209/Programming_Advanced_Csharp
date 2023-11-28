using CarManufacturer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main()
        {
            var tires = new tire[]
            {
                new tire(1, 2.5),
                new tire(1, 2.1),
                new tire(1, 0.5),
                new tire(1, 2.3),
            };
            var engine = new Engine(560, 6300);
            var lambo = new Car("Lamborghini", "Urus", 2010, 250, 9, engine, tires);

            Console.WriteLine(lambo.WhoAmI());
        }
    }
}
