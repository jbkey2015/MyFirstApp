﻿using System;

namespace MyFirstApp
{
    class Program
    {
        static void Main(string[] args)
        {            
            Console.WriteLine("Hello World!");

            Console.WriteLine("Enter your name...");
            var userEntry = Console.ReadLine();

            Console.WriteLine(userEntry);
            Console.ReadLine();

            if (userEntry == "John")
            {
                Console.WriteLine("You are awesome!");
            }
            else
            {
                Console.WriteLine("You are awesome, but not as much");
            }

            var i = 0;
            while (i < 10)
            {
                Console.WriteLine($"Current value of i is {i++}...");
                
            }

            for (var j = 0; j < 10; j++)
            {
                Console.WriteLine($"Current value of j is {j}...");
            }

            foreach (var currentCharacter in userEntry)
            {
                if (currentCharacter == 'n' || currentCharacter == 'N')
                {
                    continue;
                }
                Console.WriteLine($"the current character is {currentCharacter}");
            }

            switch (userEntry)
            {
                case "John":
                    Console.WriteLine("It's John");
                    break;
                default:
                    Console.WriteLine("Its anything but John");
                    break;
            }

            var isJohn = userEntry == "John" ? true : false;

            try
            {
                var y = 0;
                var x = 1 / y;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
