using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesGageMckenzie
{
    internal class IdleMoveStrategy : IMovementStrategy
    {
        public Positon Move(Positon positon, Positon targetPos)
        {
            Console.SetCursorPosition(positon.x, positon.y);
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine(" ");
            Console.BackgroundColor = ConsoleColor.Black;
            return positon;
        }
    }
}
