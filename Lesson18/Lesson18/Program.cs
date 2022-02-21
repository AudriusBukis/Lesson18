using Lesson18.Modules;
using System;

namespace Lesson18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("lesson 18 exeption handling");
            try
            {
                double d = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine(d);
            }
            catch (FormatException e1)
            {
                Console.WriteLine("Format exeption");
                Console.WriteLine(e1);
            }
            catch (OverflowException e2)
            {
                Console.WriteLine("Number biger then DBL_IMAX");
                Console.WriteLine(e2);
            }

            int[] newArray = { 1, 2, 3, 4, 5 };

            for (int i = 0; i < newArray.Length; i++)
            {
                Console.WriteLine(newArray[i]);
            }

            try
            {
                Console.WriteLine(newArray[8]);
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine($"error in {nameof(newArray)}: Mesage - {e}");
            }


            int[] myArray = { 19, 0, 75, 52 };

            try
            {
                for (int i = 0; i < myArray.Length; i++)
                {
                    Console.WriteLine(myArray[i] / myArray[i + 1]);
                }
            }
            catch (DivideByZeroException e1)
            {
                Console.WriteLine($"error in {nameof(myArray)}: Mesage - {e1}");
            }
            catch (IndexOutOfRangeException e2)
            {
                Console.WriteLine($"error in {nameof(myArray)}: Mesage - {e2}");
            }
           
            
            FileReaderService readFile = new FileReaderService("test.txt");

            readFile.GetAllLines();
        }


    }
}
