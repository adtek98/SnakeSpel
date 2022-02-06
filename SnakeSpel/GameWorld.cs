using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeSpel
{
    class GameWorld
    {
        public int Width = 51;
        public int Height = 21;
        public int Score = 0;
        public List<GameObject> gameObjects = new List<GameObject>();
        public Player player = new Player();
        
        public void AddFood()
        {
            if(gameObjects.Count < 2)
            {
                char[] FoodAppearance = { '*', '$', '@', '¤'};
                Random rnd = new Random();
                int rndFood = rnd.Next(0,4);
                int posX = rnd.Next(0, 50);
                int posY = rnd.Next(0, 20);
                Food food = new Food();
                food.Appearance = FoodAppearance[rndFood];  
                food.Position.X = posX;
                food.Position.Y = posY;
                gameObjects.Add(food);
            }
        }

        public void EatFood()
        {
          
            if (gameObjects[0].Position.X == gameObjects[1].Position.X && gameObjects[0].Position.Y == gameObjects[1].Position.Y)
            {
                gameObjects.RemoveAt(1);
                Score++;
            }

        }
        
        
        
        public GameWorld()
        {
            gameObjects.Add(player);
        }
        public void Update()
        {
            AddFood();
            EatFood();
            

            foreach(var x in gameObjects)
            {
                x.Update();
            }
        }
    }
}
