using System;

namespace Lesson5_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            /* This isn't the correct way to go about this...
            int number1 = 4;
            int number2 = 8;
            int number3 = 15;
            int number4 = 16;
            int number5 = 23;

            if (number1 == 16)
            {
            }
            else if (number12 == 16)
            {
            }
            else if (number3 == 16)
            {
            }
            */
            //Use an array instead

            /*
            int[] numbers = new int[5];

            numbers[0] = 4;
            numbers[1] = 8;
            numbers[2] = 15;
            numbers[3] = 16;
            numbers[4] = 23;
            //cannot create a spot outside the range of the array like this
            //numbers[5] = 42;

            //Console.WriteLine(numbers[1]);
            Console.WriteLine(numbers.Length);
            Console.ReadLine();
            */

            //int[] numbers = new int[] { 4, 8, 15, 16, 23, 45 };

            //string[] names = new string[] { "Eddie", "Alex", "Michael", "David Lee" };

            /*
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }
            Console.ReadLine();
            */

            /*
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
            Console.ReadLine();
            */

            string zig = "You can get what you want out of life" +
                "if you help enough other people get what they want.";
            //toCharArray split a string into an array of chars
            char[] charArray = zig.ToCharArray();
            //reverse the character order in the array using this helper method
            Array.Reverse(charArray);

            foreach (char zigChar in charArray)
            {
                Console.Write(zigChar);
            }
            Console.ReadLine();
        }
    }
}
