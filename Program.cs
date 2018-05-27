using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;



public class Program
{
    public static void Main(string[] args)
    {
        var strings = Console.ReadLine().Split().Select(int.Parse).ToArray();

        for (int i = 1; i <= strings.Length; i += 2)
        {
            if (strings[i] % 2 != 0)
            {
                Console.WriteLine($"Index {i} -> {strings[i]}");
            }
        }


    }


}

