using System;
using System.Collections.Generic;
using System.Linq;

/*
 * 
 * Inbal Avraham 314832908
 * Maya Rachmani 209532076
 * 
 */

namespace Tower
{
    public class MaxHeightTower
    {
        public List<Box> Boxes { get; set; }
        public Dictionary<Box, int> MaxHeightTowerByBase { get; set; }
        public Dictionary<Box, Box> BoxesAbove { get; set; }

        public MaxHeightTower(List<Box> boxes)
        {
            Boxes = boxes;
            MaxHeightTowerByBase = new Dictionary<Box, int>();
            BoxesAbove = new Dictionary<Box, Box>();
        }

        public int GetMaxHeightTower(Box baseBox)
        {
            if (MaxHeightTowerByBase.ContainsKey(baseBox))
            {
                return MaxHeightTowerByBase[baseBox];
            }

            MaxHeightTowerByBase[baseBox] = baseBox.Height;

            foreach (var box in Boxes)
            {
                if(box.Width < baseBox.Width && box.Length < baseBox.Length)
                {
                    var heightWithBoxAbove = baseBox.Height + GetMaxHeightTower(box);
                    if(heightWithBoxAbove > MaxHeightTowerByBase[baseBox])
                    {
                        MaxHeightTowerByBase[baseBox] = heightWithBoxAbove;
                        BoxesAbove[baseBox] = box;
                    }
                }
            }

            return MaxHeightTowerByBase[baseBox];
        }

        public void PrintTower()
        {
            var baseOfHeighestTower = Boxes.OrderByDescending(GetMaxHeightTower).First();

            PrintTower(baseOfHeighestTower);
        }

        private void PrintTower(Box baseBox)
        {
            if (BoxesAbove.ContainsKey(baseBox))
            {
                PrintTower(BoxesAbove[baseBox]);
            }

            Console.WriteLine($"{baseBox.Width} X {baseBox.Length} | height: {baseBox.Height}");
        }
    }
}
