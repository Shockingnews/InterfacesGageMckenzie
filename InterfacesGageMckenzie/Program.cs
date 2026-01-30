using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesGageMckenzie
{
    internal class Program
    {
        public static Positon targetPos = new Positon();
        public static Player player;
        static void Main(string[] args)
        {
            AggressiveMoveStrategy aggressiveMoveStrategy = new AggressiveMoveStrategy();
            PassiveMoveStrategy passiveMoveStrategy = new PassiveMoveStrategy();
            IdleMoveStrategy idleMoveStrategy = new IdleMoveStrategy();
            Enemy enemy = new Enemy(x: 10, y:0, ConsoleColor.Red);
            Player player = new Player(15, 15, ConsoleColor.Green);

            bool program = true;
            
            enemy._moveStrategy = aggressiveMoveStrategy;
            targetPos.x = 10;
            targetPos.y = 10;
            while (true)
            {
                Console.WriteLine(" M: to move  I: to make agressive O: to idle P: passive movement Q: To quit");


                //player.PlayerMove();
                ConsoleKeyInfo inputKeys = Console.ReadKey(true);
                Console.Clear();
                if (inputKeys.Key == ConsoleKey.M)
                {
                    Console.WriteLine("moving");
                    enemy._moveStrategy.Move(enemy._enemyPos,targetPos);
                    enemy._enemyPos = enemy._moveStrategy.Move(enemy._enemyPos, targetPos);
                }
                else if (inputKeys.Key == ConsoleKey.I)
                {
                    Console.WriteLine("changed to agressive");
                    enemy._moveStrategy = aggressiveMoveStrategy;
                    
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
                else if (inputKeys.Key == ConsoleKey.Q)
                {
                    Console.WriteLine("Program ended");
                    program = false;
                    
                }

                Console.BackgroundColor = ConsoleColor.Blue;
                Console.SetCursorPosition(targetPos.x, targetPos.y);
                Console.WriteLine(" ");
                Console.BackgroundColor = ConsoleColor.Black;

                
                Console.WriteLine("Press a button to continue");
                Console.ReadKey();
                Console.Clear();
            }
            Console.WriteLine("Press any button to quit");
            Console.ReadKey();
            Console.Clear();
        }
    }
    struct Positon
    {
        public int x;
        public int y;
    }
}
