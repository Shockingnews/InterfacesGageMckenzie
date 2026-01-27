using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesGageMckenzie
{
    internal class Player
    {
         Positon _playerPos = new Positon();
         ConsoleColor _color;
        
        public Player(int x,int y, ConsoleColor color)
        {
            _color = color;
            _playerPos.x = x;
            _playerPos.y = y;
        }
        
    }
}
