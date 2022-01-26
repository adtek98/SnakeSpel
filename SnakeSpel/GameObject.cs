using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeSpel
{
    abstract class GameObject
    {
        public Position position = new Position();
        public char appearance;

        public abstract void Update();
        
    }


}
