using System;
using System.Collections.Generic;

namespace Question_2
{
    class Program
    {
        static void Main(string[] args)
        {
            

            //int[] numbers = {1, 1,1,1 };
            // List<int> k= new List<int>();
            //int[] numbers = { 1, 4, 3, 3, 5, 2, 3, 7, 6, 8, 2 };

            int[] numbers = { 1, 3, 2, 2, 5, 2, 3, 7 };

            int count = 0;
            int max = 0; 

            for (int i = 0; i < numbers.Length ; i++)
            {
                for (int j = 0; j < numbers.Length ; j++)
                {
                    if (numbers[i] - numbers[j] == 1 || numbers[i] == numbers[j])
                    {
                        count++;

                    }
                    if(count > max) 
                    
                    {
                        max = count;
                    
                    }

                }
                count = 0;

                
                
            
            
            }
            if (max == numbers.Length) 
            {
                Console.WriteLine(0);
            }
            else 
            {
                Console.WriteLine(max);
            }

            

        }

   
    
    
    
    
    
    
    }






}
