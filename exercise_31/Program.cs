using System;

namespace exercise_31
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] newArray = new int[] { 2, 8, 0, 24, 51 };
            bool repeat = true;

            while (repeat)
            {

                Console.WriteLine("Please enter an index:");
                int index = int.Parse(Console.ReadLine());
                Console.WriteLine($"The value at index {index} is {FindIndex(index, newArray)}");
                Console.WriteLine("Would you like to continue (y|n)?:");
                string userResponse = Console.ReadLine();
                if (userResponse == "y")
                {
                    repeat = true;
                }
                else if (userResponse == "n")
                {
                    repeat = false;
                    Console.WriteLine("Goodbye!");
                }
                else
                {
                    Console.WriteLine("error");
                    repeat = true;
                }
            }
        }

        public static int FindIndex(int index, int[] array)
        {
            int i = index;
            return array[i];
        }
    }
}
