﻿namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3 ,4,5,6,7,8,9,10,11};
            int total = 0;
            
            for (int i = 0; i<numbers.Length; i++)
            {
                total += numbers[i];
            }
            Console.WriteLine("Total= "+total);
            double average=total/numbers.Length;
            Console.WriteLine("Average= " + average);
            
        }
       


    }
}
