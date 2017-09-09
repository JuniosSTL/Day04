using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day04
{
    class Monster
    {
        public string name;
        public int hp;
        public int attack;
        public float moveSpeed;

        public Monster()
        {
            name = "이름없음";
        }

        public void Move()
        {
            Console.WriteLine(name + " 이동");
        }
    }
}
