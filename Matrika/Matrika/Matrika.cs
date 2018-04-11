using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrika
{
    class Matrika
    {
        private double[,] matrix = new double[3, 3];

        //indekser
        public double this[int x, int y]
        {
            get
            {
                return matrix[x, y];
            }
            set
            {
                matrix[x, y]=value;
            }
        }

        public static int operator +(Matrika a, Matrika b)
        {

        }

        public void Izpis()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(matrix[i, j]);
                }
            }
            
        }
    }
}
