using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesGageMckenzie
{
    internal class Program
    {
        public static Player player;
        static void Main(string[] args)
        {
            AggressiveMoveStrategy aggressiveMoveStrategy = new AggressiveMoveStrategy();
            PassiveMoveStrategy passiveMoveStrategy = new PassiveMoveStrategy();
            IdleMoveStrategy idleMoveStrategy = new IdleMoveStrategy();
            Enemy enemy = new Enemy(x: 10, y:0, ConsoleColor.Red);
            Player player = new Player(15, 15, ConsoleColor.Green);
            enemy._moveStrategy = aggressiveMoveStrategy;
            while (true)
            {

                player.PlayerMove();
                ConsoleKeyInfo inputKeys = Console.ReadKey(true);
                if (inputKeys.Key == ConsoleKey.M)
                {
                    Console.WriteLine("moving");
                    enemy._moveStrategy.Move(enemy._enemyPos);
                    enemy._enemyPos = enemy._moveStrategy.Move(enemy._enemyPos);
                }
                else if (inputKeys.Key == ConsoleKey.I)
                {
                    Console.WriteLine("changed to agressive");
                    enemy._moveStrategy = aggressiveMoveStrategy;
                    //enemy._movementType=;
                }
                else if (inputKeys.Key == ConsoleKey.O)
                {
                    Console.WriteLine("changed to Idle");
                    enemy._moveStrategy = idleMoveStrategy;
                }
                else if (inputKeys.Key == ConsoleKey.P)
                {
                    Console.WriteLine("changed to passive");
                    enemy._moveStrategy = passiveMoveStrategy;
                }
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
    struct Positon
    {
        public int x;
        public int y;
    }
}
