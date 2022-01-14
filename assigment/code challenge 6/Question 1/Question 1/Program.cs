using System;

namespace Question_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Sequence = { 10, 9, 2, 5, 3, 7, 101, 18 };

            int TotalCount = SubSequence(Sequence);

           Console.WriteLine(TotalCount);
        }
    
    
        
    
    
    
    
        public static int SubSequence(int[] numbers) 
        {

            int count = 0;
            for (int i = 0; i < numbers.Length-3; i++) 
            { 
                for(int j =i+1; j<numbers.Length-2; j++)
                {
                    if (numbers[i] < numbers[j] && numbers[j] < numbers[j+1] ) 
                    {
                        count++;
                    }

                }
            
            }

            return count;
        }
    
    
    }
}
