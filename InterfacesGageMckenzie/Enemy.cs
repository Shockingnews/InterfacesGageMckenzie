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
            running,
            walking,
            attackng,
            jumping,
            random
        };
        public MovementType _movementType;
        public void Move()
        {
            if (_movementType == MovementType.attackng)
            {

            }
            else if(_movementType == MovementType.walking)
            {

            }
            else if (_movementType == MovementType.running)
            {

            }
            else if (_movementType == MovementType.jumping)
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
