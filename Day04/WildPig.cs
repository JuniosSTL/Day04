using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day04
{
    class WildPig : Monster
    {
        public WildPig()
        {
            name = "멧돼지";
        }

        public override void Move()
        {
            base.Move();
            Console.WriteLine("달려간다.");
        }
    }
}
