using System;

namespace ListExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //create list w/ 10+ ints
            //new keyword creates and empty instance of List class (ie an eplty array [])
            List<int> integerArray = new List<int>(); //usu create an empty list b/c the data get filled in later with fetched data, use input, etc
            //but could populate the list with {item1, item2, etc} if already have the data



            //Console.WriteLine("Hello Lists!");
        }
        //wrtie statis list method to find sum of EVEN nums in list
        //input: list of ints
        //output: sim of all EVEN nums
        static int AddEvensOnly(List<int> integerList) //methods use pasclase case, hence AddEvensOnly
        { //method, working as a fxn, inside of a class
foreach (int integer in integerList)
            {
                if (integer % 2 == 0)
                {
                    sum += integer;
                }
            }

        }
    }
}
