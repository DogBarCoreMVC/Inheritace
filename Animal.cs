using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritace
{
    class Animal
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Weight { get; set; }
        public string Age { get; set; }

        public void Goes()
        {
            Console.WriteLine("Goes");
        }
    }
}
