using System;

namespace Question_one
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine(" Enter an array of lenght 5 ");
            Console.WriteLine(" Enter the element in the array ");
            int element = int.Parse(Console.ReadLine());*/

            int[] arr = { 9, 10, 7, 6, 3 };
            Array.Sort(arr);

            int minisum = 0;
            int maxsum = 0;

            for (int mini = 0; mini < arr.Length -1; mini++) 
            {

                minisum += arr[mini];
            
            }
            for (int max = 1; max <arr.Length; max++)
            {

                maxsum += arr[max];

            }
            Console.WriteLine($" The minisum and the maxsum are {minisum}  and {maxsum } respesctively"  );


        }
    }
}
