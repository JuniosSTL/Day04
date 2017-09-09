using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day04
{
    class Monster
    {
        protected string name;
        public int hp;
        public int attack;
        public float moveSpeed;

        public Monster()
        {
            name = "이름없음";
        }

        public virtual void Move()
        {
            Console.Write(name + " ");
        }

        public string GetName()
        {
            return name;
        }

        public void SetName(string newValue)
        {
            //newValue 욕인지 확인
            name = newValue;
        }

        public string Name
        {
            get
            {
                return name;
            }

            //set
            //{
            //    //필터 로직
            //    //네트워크 
            //    name = value;
            //}
        }
    }
}
