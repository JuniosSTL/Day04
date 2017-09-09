using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day04
{
    class BlueSlime : Slime
    {
        public BlueSlime()
        {
            name = "파란 슬라임";
        }

        public override void Move()
        {
            base.Move();
            Console.WriteLine("파랗게 미끄러져 간다.");
        }
    }
}
