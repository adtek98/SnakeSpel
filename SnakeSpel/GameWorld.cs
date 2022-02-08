using System;
using System.Collections.Generic;
using System.Text;
   
namespace SnakeSpel
{
    class GameWorld
    {

        /// <summary>
        /// 
        /// </summary>
        public int Width = 51;
        public int Height = 21;
        public int Score = 0;
        public List<GameObject> gameObjects = new List<GameObject>();//Skapa en lista med objekt GameObject
        public Player player = new Player();//Skapa en ny spelare


        /// <summary>
        /// Metod som skapar food, om ingen Food existerar så skapar den en ny.
        /// Ger Food slumpmässigt utseende utifrån symbolerna i FoodAppearance
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
        /// Tar bort food och lägger till +1 till score om spelaren "äter" Food
        /// </summary>
        public void EatFood()
        {
          
            if (gameObjects[0].Position.X == gameObjects[1].Position.X && gameObjects[0].Position.Y == gameObjects[1].Position.Y)
            {
                gameObjects.RemoveAt(1);
                Score++;
            }

        }
        /// <summary>
        /// Lägger till spelare till gameworld
        /// </summary>
        public GameWorld()
        {
            gameObjects.Add(player);
        }

        /// <summary>
        /// Uppdatera food positioner 
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
