using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day04
{
    class Slime : Monster
    {
        public Slime()
        {
            name = "슬라임";
        }

        public override void Move()
        {
            base.Move();
            Console.WriteLine("기어간다.");
        }
    }
}
