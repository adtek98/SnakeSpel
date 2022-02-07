using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SnakeSpel 
{
    internal class Player : GameObject
    {
        public Player()
        {
            Appearance = '#';
        }
        
        public string direction;


        /// <summary>
        /// Logiken i objektrörelsen beror
        /// på vilken knapp användaren trycker på. 
        /// Spåra ett föremåls rörelse utanför spelplanen.
        /// </summary>
        public override void Update()
        {
            if(direction == "Up")
            {
                Position.Y -= 1;
            }

            if(direction == "Down")
            {
                Position.Y += 1;
            }

            if (direction == "Right")
            {
                Position.X += 1;
            }

            if (direction == "Left")
            {
                Position.X -= 1;
            }

            if(Position.X > 50)
            {
                Position.X = 0;
            }

            if (Position.X < 0)
            {
                Position.X = 50;
            }

            if (Position.Y > 20)
            {
                Position.Y = 0;
            }

            if (Position.Y < 0)
            {
                Position.Y = 20;
            }
        }
    }
}
