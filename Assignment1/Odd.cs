﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Odd
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter the limit");
            //int n = Convert.ToInt16(Console.ReadLine());

            //for (int i = 1; i < n; i++)
            //{
            //    if (i%2 != 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //Console.WriteLine("Enter the limit");
            //int n = Convert.ToInt16(Console.ReadLine());
            //int i=1;
            //while (i < n)
            //{
            //    if (i % 2 != 0)
            //    {
            //        Console.Write(i + " ");
            //    }
            //    i++;
            //}
            Console.WriteLine("Enter the limit");
            int n = Convert.ToInt16(Console.ReadLine());
            int i = 1;
            do
            {
                if (i % 2 != 0)
                {
                    Console.Write(i + " ");
                }
                i++;
            } while (i <= n);
        }
    }
}
