﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operations
{
    public class MathOperations 
    {
        public int Add(int x, int y)
        {
           return x + y;
        }

        public double Add(double a, double b, double c)
        {
            return a + b + c;   
        }

        public decimal Add(decimal a, decimal b, decimal c)
        {
            return a + b + c;
        }
    }
}
