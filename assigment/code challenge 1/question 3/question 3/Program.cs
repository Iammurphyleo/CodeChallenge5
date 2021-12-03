using System;

namespace question_3
{
    class Program
    {
        static void Main(string[] args)
        {


            /*3.A video player plays a game in which the character competes in a hurdle race.Hurdles are of varying heights, and the characters 
              have a maximum height they can jump. There is a magic potion they can take that will increase their maximum jump height by 1 unit 
                for each dose. How many doses of the potion must the character take to be able to jump all of the hurdles.
                If the character can already clear all of the hurdles, return 0.*/


            int[] height = { 1, 2, 3, 4, 5 };
            int NumberOfDose = 0;
           

             for(int dose = 1; dose < height.Length; dose++) 
             {
                NumberOfDose++;
             
             }
            Console.WriteLine(NumberOfDose);






        }
    }
}
