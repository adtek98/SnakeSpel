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
        public List<GameObject> gameObjects = new List<GameObject>();//Skapa en lista med objekt GameObject
        public Player player = new Player();//Skapa en ny spelare


        /// <summary>
        /// Metod som skapar food, om ingen Food existerar så skapar den en ny.
        /// Ger Food slumpmässigt utseende utifrån FoodType klasserna.
        /// </summary>
        public void AddFood()
        {

            if (gameObjects.Count < 2)
            {
                
                Random rnd = new Random();
                int rndFood = rnd.Next(1, 5);
                int posX = rnd.Next(0, 50);
                int posY = rnd.Next(0, 20);
                if (rndFood == 1)
                {
                    FoodType1 food1 = new FoodType1();
                    food1.Position.X = posX;
                    food1.Position.Y = posY;
                    gameObjects.Add(food1);
                }
                if (rndFood == 2)
                {
                    FoodType2 food2 = new FoodType2();
                    food2.Position.X = posX;
                    food2.Position.Y = posY;
                    gameObjects.Add(food2);
                }
                if (rndFood == 3)
                {
                    FoodType3 food3 = new FoodType3();
                    food3.Position.X = posX;
                    food3.Position.Y = posY;
                    gameObjects.Add(food3);
                }
                if (rndFood == 4)
                {
                    FoodType4 food4 = new FoodType4();
                    food4.Position.X = posX;
                    food4.Position.Y = posY;
                    gameObjects.Add(food4);
                }

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
