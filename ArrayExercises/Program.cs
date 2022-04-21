using System;

namespace ArrayExercises
{
    class Program
    {
        static void Main(string[] args)
        { 
int[] intArray = {1, 1, 2, 3, 5, 8};
            Console.WriteLine(intArray);
            //for (int i = 0; i < intArray.Length; i++)
            //{
            //    Console.WriteLine(intArray[i]);
            //}

                foreach (int integer in intArray)
            {
                if (integer % 2 != 0) {  //or could do %2 == 1
                       Console.WriteLine(integer);
    
                }
            }
        }
    }
}
