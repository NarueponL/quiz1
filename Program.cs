using System;
using System.Collections.Generic;

namespace quiz
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalRose=0;
            int totalSunFlower=0;

            GetAmountPlant(ref totalRose, ref totalSunFlower);
            GetFlowerInformation(totalRose);
            

        }

        static void GetAmountPlant(ref int totalrose , ref int totalsunflower)
        {
            
            Console.Write("Input Total Rose : ");
            totalrose = int.Parse(Console.ReadLine());
            Console.Write("Input Total Sun Flower : ");
            totalsunflower = int.Parse(Console.ReadLine());
        }
        static void GetFlowerInformation(int total)
        {
            for(int i = 1; i <= total; i++)
            {
                

            }
        }
    }
}
