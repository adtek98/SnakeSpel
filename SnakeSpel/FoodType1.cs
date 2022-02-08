using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeSpel
{
    internal class FoodType1 : Food 
    {
        public FoodType1()
        {
            /// <summary>
            /// Konstruktor med Appearance för hur den ska se ut.
            /// </summary>
            Appearance = '@';
        }
    }
}
