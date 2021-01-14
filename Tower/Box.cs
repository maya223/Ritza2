using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tower
{
    class Box
    {
        public int Width { get; set; }
        public int Length { get; set; }
        public int Height { get; set; }
        public Box BoxAbove { get; set; }
    }
}
