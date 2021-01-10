using System;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            getNumsArrayMax();
            Console.WriteLine("Hello World!");
        }

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
            Console.WriteLine("You can select any number from this list: ");
            // https://stackoverflow.com/questions/16265247/printing-all-contents-of-array-in-c-sharp
            Console.Write("[{0}]", string.Join(", ", nums));
            Console.WriteLine("However your scoring will be depend on the frequency of that number in the list." +
                " E.g for [2,2,3,5,4] if you pick 2 your score will be 4 (2 * 2) but if you pick 5 your score will be 5 (5 * 1");

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
                            Console.WriteLine("I gave you a list of numbers pick one of these numbers:");
                            Console.Write("[{0}]", string.Join(", ", nums));
                        }
                    } while (!nums.Contains(num));
                    notFound = false;
                }
                catch
                {
                    Console.WriteLine("I gave you a list of numbers pick one of these numbers:");
                    Console.Write("[{0}]", string.Join(", ", nums));
                }
            }
            ArrayMaxResult(nums, num);
        }


        static int ArrayMaxResult(int [] nums, int num)
        {
            int counter = 0;
            for(int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == num) counter++;
            }
            return num * counter;
        }
    }
}
