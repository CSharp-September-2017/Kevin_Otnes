using System;
using System.Collections.Generic;
namespace fizzbuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 10;
            string word = "Hello";
            bool flag = true;
            int[] numArray = new int[5]; 
            List<string> myList =new List<string>();
            for (int i=0; i < numArray.Length; i++)
            {
                    if (i < 4)
                    {
                        Console.WriteLine(i);
                    }
            }
            Fizzbuzz(number);
        }

        public static void Fizzbuzz(int limit)
        {
            for (int i = 1; i < limit; i++)
            {
                Console.WriteLine(i);
            }      
        }
    }
}
