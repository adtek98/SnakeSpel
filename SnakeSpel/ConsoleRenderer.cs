using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeSpel
{
    class ConsoleRenderer
    {
        private GameWorld world;
        public ConsoleRenderer(GameWorld gameWorld)
        {
            // TODO Konfigurera Console-fönstret enligt världens storlek
           
            world = gameWorld;
            Console.SetWindowSize(world.Width, world.Height);
        }

        public void Render()
        {

            //Console.Clear();
            Console.CursorVisible = false;
            Console.WriteLine(world.Score);
          
            foreach (var Object in world.gameObjects)
            {

                Console.SetCursorPosition(Object.Position.X, Object.Position.Y);
                Console.Write(Object.Appearance);
                
            }

            //for (int i = 0; i)

            // TODO Rendera spelvärlden (och poängräkningen)

            // Använd Console.SetCursorPosition(int x, int y) and Console.Write(char)
        }

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
