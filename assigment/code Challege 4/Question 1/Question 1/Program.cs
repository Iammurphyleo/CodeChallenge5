using System;

namespace Question_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");


            int[] number = {2, 5, 6, 7, 8, 9, 12 };

            int T = 8;

            ReturnTarget(number, T);
        
        
        
        }
        public static void ReturnTarget(int[] number,int T ) 
        {
            int check = 0;
            for (int i = 0; i < number.Length; i++) 
            {
                if (T == number[i])
                {
                    Console.Write($"{i},");
                }
                else 
                {
                    check++;
                }
            }
            if ( check == number.Length) 
            {
                Console.WriteLine("-1, -1");
            }
        }

   
    
    
    }
}
