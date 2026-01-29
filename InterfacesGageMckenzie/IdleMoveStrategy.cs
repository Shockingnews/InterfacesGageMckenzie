using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesGageMckenzie
{
    internal class IdleMoveStrategy : IMovementStrategy
    {
        public Positon Move(Positon positon)
        {
            positon.x += 1;
            positon.y += 1;
            return positon;
        }
    }
}
