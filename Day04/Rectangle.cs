﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day04
{
    class Rectangle : Shape
    {
        public override void Draw()
        {
            base.Draw();

            Console.WriteLine("사각형");
        }
    }
}
