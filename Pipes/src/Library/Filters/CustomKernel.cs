using System;
using System.Drawing;
using CompAndDel;

namespace CompAndDel.Filters;

public class CustomKernel
{
    public int[,] customkernel = new int[3,3];
    public CustomKernel()
    {
        for(int x = 0; x < 3; x++)
        {
            for(int y = 0; y < 3; y++)
            {
                int input;
                Console.WriteLine($"Please type the value for ({x},{y}");
                while(!int.TryParse(Console.ReadLine(), out input))
                {
                    Console.WriteLine("Incorrect input");
                }
                customkernel[x,y] = input;
            }
        }
    }
}