using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesGageMckenzie
{
    internal class AggressiveMoveStrategy : IMovementStrategy
    {
        
        public Positon Move(Positon positon)
        {
            
            if (positon.x != 0)
            {
                positon.x += 1;
            }
            if (positon.y != 0) 
            { 
                positon.y += 1; 
            }
            Console.SetCursorPosition(positon.x, positon.y);
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine(" ");
            Console.BackgroundColor = ConsoleColor.Black;

            return positon;
        }
    }
}
