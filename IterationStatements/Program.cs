using System;
using System.Collections.Generic;

namespace IterationStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO
            var numbers= new List <int> ();
            int num = 0;
            //Create a List called "numbers"
            //Create a variable of type int with an initializer of 0



            // Create a do-while loop
            do
            {
                // Increment your variable by 1
                num++;
                // Then add your variable to "numbers"
                numbers.Add(num);

            }
            while (num < 100);
            // While your variable is less than 100



            // Create a while loop
            // While your variable is less than 200
            while(num < 200)
            {
                // Increment your variable by 1
                num++;
                // Then add your variable to "numbers"
                numbers.Add(num);

            }

            Console.WriteLine("Increase:");

            // Create a foreach loop
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
            // Write your variable to the console

            Console.WriteLine("");
            Console.WriteLine("Decrease:");

            // Create a for loop
            // in your initializer set the value of i to 199
            // in your conditional, as long as i is less than or equal to the length of "numbers"
            // and as long as i is greater than or equal to 0
            // Decrement i by 1
            for (num = 199; num <= numbers.Count && num > 0; num--) 
            {
                // Write to the console "numbers" at index i
                Console.WriteLine(num);
            }
        }
    }
}
