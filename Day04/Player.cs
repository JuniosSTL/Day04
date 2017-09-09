using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day04
{
    class Player
    {
        public string id;
        public string name;
        public int hp;
        public int attack;
        public float moveSpeed;

        public void Move()
        {
            Console.WriteLine(id + " 움직임.");
        }
    }
}
