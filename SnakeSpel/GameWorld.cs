﻿using System;
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

      
        /// <summary>
        /// Method for creating food. If no food exists it creates a new one.
        /// </summary>
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
        /// <summary>
        /// This method deletes  the food and adds +1 to the score if the player runs over Food
        /// </summary>
        public void EatFood()
        {
          
            if (gameObjects[0].Position.X == gameObjects[1].Position.X && gameObjects[0].Position.Y == gameObjects[1].Position.Y)
            {
                gameObjects.RemoveAt(1);
                Score++;
            }
<<<<<<< HEAD

=======
>>>>>>> fd53f830d6542fc8c9a7ec986a43d39534506e71
        }
        /// <summary>
        /// Adds player to the gameworld
        /// </summary>
        public GameWorld()
        {
            gameObjects.Add(player);
        }
        /// <summary>
        /// 
        /// </summary>
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
