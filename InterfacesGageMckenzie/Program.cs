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
            Enemy enemy = new Enemy(x: 1, y:0, ConsoleColor.Red);
            ConsoleKeyInfo inputKeys = Console.ReadKey(true);
            if (inputKeys.Key == ConsoleKey.M)
            {
                enemy.Move();
            }
            else if (inputKeys.Key == ConsoleKey.I)
            {
                enemy._movementType=;
            }
            else if (inputKeys.Key == ConsoleKey.O)
            {

            }
            else if (inputKeys.Key == ConsoleKey.P)
            {

            }
        }
    }
    struct Positon
    {
        public int x;
        public int y;
    }
}
