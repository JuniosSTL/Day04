using System;

namespace Day04
{
    class Program
    {
        static void Main(string[] args)
        {
#region Player
            Player[] players = new Player[2];
            players[0] = new Player();
            players[0].id = "junios";
            players[0].name = "강희운";
            players[0].attack = 100;
            players[0].hp = 100;
            players[0].moveSpeed = 10;

            players[1] = new Player();
            players[1].id = "babo";
            players[1].name = "김대유";
            players[1].attack = 10;
            players[1].hp = 10;
            players[1].moveSpeed = 0.1f;

            players[0].Move();
            players[1].Move();
            #endregion

#region 몬스터
            Goblin goblin = new Goblin();
            WildPig pig = new WildPig();
            Slime slime = new Slime();
            BlueSlime bSlime = new BlueSlime();

            slime.name = "슬라임";
            slime.Move();

            bSlime.name = "파란슬라임";
            bSlime.Move();
#endregion

        }
    }
}
