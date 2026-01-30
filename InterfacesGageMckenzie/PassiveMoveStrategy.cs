using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesGageMckenzie
{
    internal class PassiveMoveStrategy : IMovementStrategy
    {

        public Positon Move(Positon positon, Positon targetPos)
        {
            if (positon.x == targetPos.x || positon.x != targetPos.x)
            {
                positon.x -= 1;
            }
            if (positon.y == targetPos.y || positon.y != targetPos.y)
            {
                positon.y -= 1;
            }
            Console.SetCursorPosition(positon.x, positon.y);
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine(" ");
            Console.BackgroundColor = ConsoleColor.Black;
            return positon;
        }
    }
}
