﻿using System;

namespace StaircaseSample
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 150;
            
            for (int j = 0; j < n; j++)
            {
                for (int i = n - 1; i >= 0; i--)
                {
                    if (i <= j)
                    {
                        Console.Write("#");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                
                Console.WriteLine("");
            }

        }
        
    }
}
