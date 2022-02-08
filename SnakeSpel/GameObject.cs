using SnakeSpel;
using System;
using System.Collections.Generic;
using System.Text;


namespace SnakeSpel
{

    /// <summary>
    /// En abstrakt klass som definierar ett scenario för metoder för klasser som ärver
    /// </summary>
    abstract class GameObject
    {
        public Position Position = new Position();//skapa en ny position på spelplanen.
        public char Appearance;

        public abstract void Update();//krävs metod för alla  klasser som ärver
    }
}
