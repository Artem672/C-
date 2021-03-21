using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            #region FirstTask
            /*
            ConsoleKeyInfo Button;
            do
            {
                //I don't know how to clean my value and on 2 and 3 time it needs to skip.
                Console.WriteLine("Enter esc to exit!");
                Console.Write("Enter char -> ");
                char Key = Convert.ToChar(Console.Read());

                if ('A' <= Key && Key <= 'Z')
                {
                    Console.WriteLine("Input: {0}, Result: {1}", Key, Key.ToString().ToLower());
                }
                else if ('a' <= Key && Key <= 'z')
                {
                    Console.WriteLine("Input: {0}, Result: {1}", Key, Key.ToString().ToUpper());
                }

                Button = Console.ReadKey();
                Key = default(char);
                Console.Clear();

            } while (Button.Key != ConsoleKey.Escape);
            */
            #endregion

            #region SecondTask
            int[] FirstArray = { -4, -2, 9, 3, 6, 2, -7};
            int[] SecondArray = { 1, -7, -4, 9, -4, 9 };
            //int[] ThirdArray = UniteArrays(FirstArray, SecondArray); // First part of second task
            int[] ThirdArray = SimilarItems(FirstArray, SecondArray);
            //int[] ThirdArray = DisSimilarItems(FirstArray,SecondArray); // Third part of second task
            foreach (var item in ThirdArray)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();

            #endregion

            #region ThirdTask
            /*
            int[] Value = { 1, 2, -4, -55, - 7, 10, 100 };
            int[] LessZero = Array.FindAll(Value, x => x <= 0);
            int[] MoreZero = Array.FindAll(Value, x => x > 0);
            int[] ResultArray = new int[Value.Length];

            LessZero.CopyTo(ResultArray, 0);
            MoreZero.CopyTo(ResultArray, LessZero.Length);

            foreach(var item in ResultArray)
            {
                Console.Write($"{item} ");
            }
            */
            #endregion
        }

        static int[] UniteArrays(int[] FirstArray,int[] SecondArray)
        {
            int[] ResultArray = new int[FirstArray.Length + SecondArray.Length];

            FirstArray.CopyTo(ResultArray, 0);
            SecondArray.CopyTo(ResultArray, FirstArray.Length);

            return ResultArray;
        }

        static int[] SimilarItems(int[] FirstArray, int[] SecondArray)
        {
            int[] ResultArray = new int[0];

            foreach (var item in FirstArray)
            {
                if (Array.IndexOf(SecondArray, item) != -1)
                {
                    if(Array.IndexOf(ResultArray,item) == -1)
                    {
                        Array.Resize(ref ResultArray, ResultArray.Length + 1);
                        ResultArray[ResultArray.Length - 1] = item;
                    }
                }
            }
            return ResultArray;
        }

        static int[] DisSimilarItems(int[] FirstArray, int[] SecondArray)
        {
            int[] ResultArray = new int[0];

            foreach(var item in FirstArray)
            {
                if(Array.IndexOf(SecondArray,item) == -1)
                {
                    Array.Resize(ref ResultArray, ResultArray.Length + 1);
                    ResultArray[ResultArray.Length - 1] = item;

                }
            }

            return ResultArray;
        }
    }
}
