using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesGageMckenzie
{
    internal class Enemy
    {
        private Positon _enemyPos = new Positon();
        private ConsoleColor _color;
        
        public Enemy(int x, int y, ConsoleColor color) 
        { 
            _color = color;
            _enemyPos.x = x;
            _enemyPos.y = y;
        }
        public enum MovementType
        {
            Idle,
            Passive,
            agrvsive,
            random
        };
        public MovementType _movementType;
        public void Move()
        {
            
            
             if (_movementType == MovementType.Passive)
            {

            }
            else if (_movementType == MovementType.agrvsive)
            {

            }
            else if (_movementType == MovementType.Idle)
            {

            }
            else if (_movementType == MovementType.random)
            {

            }

        }
    }
}
