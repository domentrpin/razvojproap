using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrika
{
    class Program
    {
        static void Main(string[] args)
        {
            Matrika a = new Matrika();
            Matrika b = new Matrika();
            Init(a);
            Init(b);

            Matrika c = a + b;
            a.Izpis();
            Console.WriteLine("+");

            Matrika c = a + b;
            a.Izpis();
            Console.WriteLine("=");

            Matrika c = a + b;
            a.Izpis();
            Console.ReadLine();

        }
        static void Init(Matrika x)
        {
            Random r = new Random();
            for(int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    x[i, j] = r.Next(10);
                }
            }
        }
    }
}
