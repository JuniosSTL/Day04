using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day04
{
    class TV
    {
        public void Display()
        {
            Decode();
            Console.WriteLine("Display");
        }

        private void Decode()
        {
            Console.WriteLine("Decode");
        }
    }
}
