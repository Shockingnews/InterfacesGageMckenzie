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
        
        public void PlayerMove()
        {
            ConsoleKeyInfo inputKeys = Console.ReadKey(true);
            if(inputKeys.Key == ConsoleKey.W)
            {
                _playerPos.y -= 1;
                Console.SetCursorPosition(_playerPos.x, _playerPos.y);
                Console.BackgroundColor = _color;
                Console.WriteLine(" ");
            }
            else if (inputKeys.Key == ConsoleKey.S)
            {
                _playerPos.y += 1;
                Console.SetCursorPosition(_playerPos.x, _playerPos.y);
                Console.BackgroundColor = _color;
                Console.WriteLine(" ");
            }
            else if (inputKeys.Key == ConsoleKey.A)
            {
                _playerPos.x -= 1;
                Console.SetCursorPosition(_playerPos.x, _playerPos.y);
                Console.BackgroundColor = _color;
                Console.WriteLine(" ");
            }
            else if (inputKeys.Key == ConsoleKey.D)
            {
                _playerPos.x += 1;
                Console.SetCursorPosition(_playerPos.x, _playerPos.y);
                Console.BackgroundColor = _color;
                Console.WriteLine(" ");
            }
            Console.BackgroundColor = ConsoleColor.Black;
        }
    }
}
