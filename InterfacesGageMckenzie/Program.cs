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
            while (true)
            {


                ConsoleKeyInfo inputKeys = Console.ReadKey(true);
                if (inputKeys.Key == ConsoleKey.M)
                {
                    Console.WriteLine("moving");
                    enemy.Move();
                }
                else if (inputKeys.Key == ConsoleKey.I)
                {
                    Console.WriteLine("changed to agressive");
                    enemy.ChangeMovement(inputKeys.KeyChar);
                    //enemy._movementType=;
                }
                else if (inputKeys.Key == ConsoleKey.O)
                {
                    Console.WriteLine("changed to Idle");
                    enemy.ChangeMovement(inputKeys.KeyChar);
                }
                else if (inputKeys.Key == ConsoleKey.P)
                {
                    Console.WriteLine("changed to passive");
                    enemy.ChangeMovement(inputKeys.KeyChar);
                }
            }
        }
    }
    struct Positon
    {
        public int x;
        public int y;
    }
}
