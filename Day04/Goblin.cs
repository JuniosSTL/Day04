using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day04
{
    class Goblin : Monster
    {
        public Goblin()
        {
            name = "고블린";
        }

        public override void Move()
        {
            base.Move();
            Console.WriteLine("뛰어간다");
        }
    }
}
