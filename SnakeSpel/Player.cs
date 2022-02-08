namespace SnakeSpel
{
    internal class Player : GameObject
    {
        /// <summary>
        /// Konstruktor för player med Appearance för hur den ska se ut.
        /// </summary>
        public Player()
        {
            Appearance = '#';
        }
        
        public string direction;

        /// <summary>
        /// Logik för hur Player ska röra sig när man trycker ner piltangenterna.
        /// Skickar tillbaka Player till spelplanen ifall den går ur den.
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
