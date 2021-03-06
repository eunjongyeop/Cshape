﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex11_IsAs
{
    class Program
    {
        static void Main(string[] args)
        {
            object[] objectArr = new object[] { 8.9, "dog", 6, 'c', null, 15.99, 745, true };

            Console.WriteLine(SumDoubleOnly(objectArr));
        }

        private static double SumDoubleOnly(object[] objectArr)
        {
            double sum=0;

            foreach(object o in objectArr)
            {
                if(o is double)
                {
                    sum += (double)o;
                }
            }

            return sum;
        }
    }
}
