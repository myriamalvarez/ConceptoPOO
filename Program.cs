﻿using System;

namespace ConceptoPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Conceptos POO");
            Console.WriteLine("=============");
             
            try
            {
	            Console.WriteLine(new Date(2024, 2, 29));
	            Console.WriteLine(new Date(1974, 9, 23));
	            Console.WriteLine(new Date(1985, 11, 5));
            }
            catch (Exception error)
{
	
	Console.WriteLine(error.Message);
}
        }
    }
}
