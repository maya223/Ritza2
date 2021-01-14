using System;
using System.Collections.Generic;

/*
 * 
 * Inbal Avraham 314832908
 * Maya Rachmani 209532076
 * 
 */

namespace Tower
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var boxes = GenerateBoxesList(20);
            new MaxHeightTower(boxes).PrintTower();

            Console.WriteLine("----------------------------");

            boxes = GenerateBoxesList(30);
            new MaxHeightTower(boxes).PrintTower();
        }

        private static List<Box> GenerateBoxesList(int n)
        {
            var rnd = new Random();
            var boxes = new List<Box>();

            for(var i=0; i< n; i++)
            {
                boxes.Add(new Box
                {
                    Width = rnd.Next(200),
                    Length = rnd.Next(200),
                    Height = rnd.Next(200)
                });
            }

            return boxes;
        }
    }
}
