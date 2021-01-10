using System;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // ArrayMaxResult
           // getNumsArrayMax();
            // Leap Year Calculator 
           // IsLeapYear(1997);
           // IsLeapYear(1996);
            //IsLeapYear(1900);
           // IsLeapYear(2000);
            // Perfect Sequence
            int[] test = new int[] { 2, 2 };
            Console.WriteLine(PerfectSequence(test));
            test = new int[] { 0, 0, 0, 0 };
            Console.WriteLine(PerfectSequence(test));
            test = new int[] { 1, 3, 2 };
            Console.WriteLine(PerfectSequence(test));
            test = new int[] { 4, 5, 6 };
            Console.WriteLine(PerfectSequence(test));
            test = new int[] { 0, 2, -2 };
            Console.WriteLine(PerfectSequence(test));
        }

        //================== Array Max Result ===================
        /*Create a Console application that requests 5 numbers between 1-10 from the user. 
        Output the array to the console and ask the user to select a number. 
        After the selection, output the “score” of the number chosen.
        */
        static void getNumsArrayMax()
        {
            int[] nums = new int[5];
            int num = 0;
            for(int i = 0; i < nums.Length; i++)
            {
                bool notValid = true;
                while (notValid)
                {
                    try
                    {
                        do {
                            Console.WriteLine("Please give me a number between 1-10.");
                            num = int.Parse(Console.ReadLine());
                            if (num < 1 || num > 10) Console.WriteLine("The number needs to be between 1 and 10.");
                        } while (num < 1 || num > 10);
                        notValid = false;
                    }
                    catch
                    {
                        Console.WriteLine("Please only use numbers between 1-10");
                    }
                }
                nums[i] = num;
            }
            Console.Write("You can select any number from this list: ");
            // https://stackoverflow.com/questions/16265247/printing-all-contents-of-array-in-c-sharp
            Console.WriteLine("[{0}]", string.Join(", ", nums));
            Console.WriteLine("However your scoring will be depend on the frequency of that number in the list." +
                " E.g for [2,2,3,5,4] if you pick 2 your score will be 4 (2 * 2) but if you pick 5 your score will be 5");

            bool notFound = true;
            while (notFound)
            {
                try
                {
                    do
                    {
                        num = int.Parse(Console.ReadLine());
                        if (!nums.Contains(num))
                        {
                            Console.Write("I gave you a list of numbers pick one of these numbers:");
                            Console.WriteLine("[{0}]", string.Join(", ", nums));
                        }
                    } while (!nums.Contains(num));
                    notFound = false;
                }
                catch
                {
                    Console.Write("I gave you a list of numbers pick one of these numbers:");
                    Console.WriteLine("[{0}]", string.Join(", ", nums));
                }
            }
            ArrayMaxResult(nums, num);
        }

        //------------------------------------------------------
        static void ArrayMaxResult(int [] nums, int num)
        {
            int counter = 0;
            for(int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == num) counter++;
            }
            Console.WriteLine(num * counter);
        }

        //============ Is Leap Year ================
        /*
          on every year that is evenly divisible by 4
          except every year that is evenly divisible by 100
          unless the year is also evenly divisible by 400
         */

        static bool IsLeapYear(int year)
        {
            if (year % 400 == 0)
            {
                Console.WriteLine(year + " is a leap year.");
                return true;
            }
            if(year % 4 == 0 && year % 100 != 0)
            {
                Console.WriteLine(year + " is a leap year.");
                return true;
            }
            Console.WriteLine(year + " is not a leap year.");
            return false;
        }

        //=========== Perfect Sequences ============
        /*
        Given an array, return “Yes” if the sequence is considered a perfect sequence. 
        Otherwise, return “No”
        Algorithm:
        write for loop
           check that number id greater then 0 if not return no
           add num to sum variable
           multiply var equals var * num
        after loop check if add var and multiply var are equal 
        if they are return "yes"
        if not return "no"
        */
        static String PerfectSequence(int [] nums)
        {
            int sum = 0, product = 1;
            
            foreach(int num in nums)
            {
                if (num < 0) return "No";
                sum += num;
                product = product * num;
            }

            if (sum == product) return "Yes";

            return "No";
        }
    }// end of main
}// end of class

