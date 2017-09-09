using System;

namespace Day04
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            player.id = "babo";
            Random r = new Random();


            Monster[] monsters = new Monster[r.Next(1, 30)];
            for (int i = 0; i < monsters.Length; i++)
            {
                int type = r.Next(0, 5);
                switch (type)
                {
                    case 0:
                        monsters[i] = new Slime();
                        break;
                    case 1:
                        monsters[i] = new Goblin();
                        break;
                    case 2:
                        monsters[i] = new WildPig();
                        break;
                    case 3:
                        monsters[i] = new BlueSlime();
                        break;
                    case 4:
                        monsters[i] = new Goblin();
                        break;
                }
            }



            player.Move();
            for(int i =0; i < monsters.Length; i++)
            {
                monsters[i].Move();
            }


        }
    }
}
