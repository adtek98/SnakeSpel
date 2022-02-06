using SnakeSpel;
using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeSpel
{
    
    abstract class GameObject
    {
        
        public Position Position = new Position();
        public char Appearance;

        public abstract void Update();
    }
}
