using System;
using System.Net.NetworkInformation;

namespace MethodOverloading
{
    public class Program
    {
        static void Main(string[] args)
        {
            int add1 = Add(2, 3);
            double add2 = Add(4.3, 5.78);

            
            
            Console.WriteLine(add1);
            Console.WriteLine(add2);
        }

        //Create method named Add, that accepts two int's and returns sum

        public static int Add(int w, int s)
        {
            return w + s;
        }


        //Create method(overload) named Add, adding two decimals
        public static double Add(double w, double s)
        {
            return w + s;
        }


        //Create method(overload) named Add, return a string and accepts 3 parameters, 2 ints and a bool
        //Now create another overload of the Add method that returns a string and accepts 3 parameters: 2 integers and 1 boolean
        //If the boolean parameter is equal to true, the Add method will return the sum of the 2 numbers plus the word “dollars” at the end of the string.
        //You must also account for the appropriate grammar of the string - so it can’t be “1 dollars”

        //public static string Add(int w, int s, bool d)
        //{
            //need a if statement?, dollars and dollar(if sum is 1 <= dollar, if 1>= dollars?

       //     if (d)
       //     {

       //     }
       // }

       // Create a method named Add, that accepts two integers and returns the sum of those two integers
       // Now create an overload of the Add method to account for being able to add two decimals together
       // Now create another overload of the Add method that returns a string and accepts 3 parameters: 2 integers and 1 boolean
      //  If the boolean parameter is equal to true, the Add method will return the sum of the 2 numbers plus the word “dollars” at the end of the string.
       // You must also account for the appropriate grammar of the string - so it can’t be “1 dollars”



    }
}
