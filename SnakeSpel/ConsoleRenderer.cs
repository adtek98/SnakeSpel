using System;
using System.Collections.Generic;
using System.Text;


namespace SnakeSpel
{
    class ConsoleRenderer
    {
        private GameWorld world;

        /// <summary>
        /// Konfigurerar Console-fönstret enligt världens storlek
        /// </summary>
        /// <param name="gameWorld">Objekt av klass GameWorld</param>
        public ConsoleRenderer(GameWorld gameWorld)
        {         
            world = gameWorld;
            Console.SetWindowSize(world.Width, world.Height);
        }

        /// <summary>
        /// Renderar alla objekt på spelplanen
        /// </summary>
        public void Render()
        {
            Console.CursorVisible = false;
            Console.WriteLine("Score: " + world.Score);
          
            foreach (var Object in world.gameObjects)
            {
                Console.SetCursorPosition(Object.Position.X, Object.Position.Y); //Beteckning för varje objekts position                
                Console.Write(Object.Appearance); //Utseendebeteckning för ett objekt                
            }

        }

        /// <summary>
        /// Metoden går igenom alla renderbara objekt i 
        /// WORLD och skriver blanka utrymmen vid varje position.
        /// </summary>
        public void RenderBlank()
        {
            for(int x = 0; x < 51; x++)
            {
                for (int y = 0; y < 21; y++)
                {
                    Console.SetCursorPosition(x, y);
                    Console.Write(' ');
                }
            }
            Console.SetCursorPosition(0, 0);
            
        }
    }
}
