using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesGageMckenzie
{
    internal class Enemy
    {
        public Positon _enemyPos = new Positon();
        private ConsoleColor _color;
        
        public IMovementStrategy _moveStrategy;
        
        public Enemy(int x, int y, ConsoleColor color) 
        { 
            _color = color;
            _enemyPos.x = x;
            _enemyPos.y = y;
            
        }
        

        // enum MovementType
        //{
        //    Idle,
        //    Passive,
        //    agrvsive
        //};
        // MovementType _movementType;

        //public void ChangeMovement(char input)
        //{
        //    if(input == 'i')
        //    {
        //        _movementType = MovementType.agrvsive;
        //    }
        //    else if (input == 'o')
        //    {
        //        _movementType = MovementType.Passive;
        //    }
        //    else if (input == 'p')
        //    {
        //        _movementType = MovementType.Idle;
        //    }
        //}
        //public void Move()
        //{
            
            
        //     if (_movementType == MovementType.Passive)
        //     {
        //        _enemyPos.x += 1;
        //        _enemyPos.y += 1;
        //        Console.SetCursorPosition(_enemyPos.x, _enemyPos.y);
        //        Console.ForegroundColor = _color;
        //        Console.WriteLine(" ");
        //    }
        //    else if (_movementType == MovementType.agrvsive)
        //    {
        //        _enemyPos.x += 2;
        //        _enemyPos.y += 2;
        //        Console.SetCursorPosition(_enemyPos.x, _enemyPos.y);
        //        Console.ForegroundColor = _color;
        //        Console.WriteLine(" ");
        //    }
        //    else if (_movementType == MovementType.Idle)
        //    {
        //        Console.WriteLine("idle");
        //    }
            

        //}
    }
}
