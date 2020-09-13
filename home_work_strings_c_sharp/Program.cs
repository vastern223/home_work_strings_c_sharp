using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace home_work_strings_c_sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            ///////////////////////////////1 завдання

            //int[] arr1 = new int[10];
            //int[] arr2 = new int[10];
            //int[] arr3 = new int[10];
            //Random rand = new Random();

            //for (int i = 0; i < arr1.Length; i++)
            //{
            //    arr1[i] = rand.Next(1, 10);
            //    arr2[i] = rand.Next(1, 10);

            //}
            //int k = 0;
            //bool check = true;

            //for (int i = 0; i < arr1.Length; i++)
            //{

            //    for (int j = 0; j < arr2.Length; j++)
            //    {
            //        if (arr1[i] == arr2[j])
            //        {
            //            for (int l = 0; l < arr3.Length; l++)
            //            {
            //                if (arr3[l] == arr1[i])
            //                {
            //                    check = false;
            //                }
            //            }
            //            if (check == true)
            //            {
            //                arr3[k] = arr1[i];
            //                k++;
            //                break;
            //            }
            //            else
            //            {
            //                check = true;
            //            }

            //        }
            //    }
            //}

            //for (int i = 0; i < arr1.Length; i++)
            //{
            //    Console.Write(" " + arr1[i]);
            //}
            //Console.WriteLine("\n");

            //for (int i = 0; i < arr2.Length; i++)
            //{
            //    Console.Write(" " + arr2[i]);
            //}
            //Console.WriteLine("\n");

            //for (int i = 0; i < arr3.Length; i++)
            //{
            //    if (arr3[i] != 0)
            //    {
            //        Console.Write(" " + arr3[i]);
            //    }
            //}
            //Console.WriteLine("\n");


            /////////////////////////////////////////2 завданя
            ///
            //string word;
            //Console.Write(" enter string  :");
            //word = Console.ReadLine();
            //char[] newword = word.ToCharArray();
            //Array.Reverse(newword);
            //string finaltext = new string(newword);

            //if (word == finaltext)
            //{
            //    Console.WriteLine(" polyndrome");
            //}
            //else
            //{
            //    Console.WriteLine(" not polyndrome");
            //}


            /////////////////////////////////////////3 завдання

            //string sentense = " mno, lol ,bla! tut kek?";
            //string[] words = sentense.Split(new char[] { ' ', ',', '!', '?', '.' }, StringSplitOptions.RemoveEmptyEntries);
            //int count_of_words = 0;
            //foreach (var word in words)
            //{
            //    ++count_of_words;
            //}
            //Console.WriteLine("Count of words: " + (int)count_of_words);


            /////////////////////////////////////////4 завдання

            //int[,] arr = new int[5, 5];
            //Random rand = new Random();
            //int sum = 0;

            //int min_index_i = 0;
            //int min_index_j = 0;
            //int max_index_i = 0;
            //int max_index_j = 0;

            //for (int i = 0; i < arr.GetLength(0); i++)
            //{
            //    for (int j = 0; j <= arr.GetUpperBound(1); j++)
            //    {
            //        arr[i, j] = rand.Next(-100, 101);
            //        Console.Write(arr[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}

            //int min = arr[0, 0];
            //int max = arr[0, 0];

            //for (int i = 0; i < arr.GetLength(0); i++)
            //{
            //    for (int j = 0; j <= arr.GetUpperBound(1); j++)
            //    {
            //        if (arr[i, j] > max)
            //        {
            //            max = arr[i, j];
            //            max_index_i = i;
            //            max_index_j = j;
            //        }
            //    }
            //}

            //for (int i = 0; i < arr.GetLength(0); i++)
            //{
            //    for (int j = 0; j <= arr.GetUpperBound(1); j++)
            //    {
            //        if (arr[i, j] < min)
            //        {
            //            min = arr[i, j];
            //            min_index_i = i;
            //            min_index_j = j;
            //        }
            //    }
            //}

            //if (min_index_i < max_index_i)
            //{
            //    for (int i = min_index_i; i <= max_index_i; i++)
            //    {
            //        for (int j = 0; j < arr.GetLength(0); j++)
            //        {
            //            if (i == min_index_i && j > min_index_j)
            //            {
            //                sum += arr[i, j];
            //            }
            //            else if (i > min_index_i && i < max_index_i)
            //            {
            //                sum += arr[i, j];
            //            }
            //            else if (i == max_index_i && j < max_index_j)
            //            {
            //                sum += arr[i, j];
            //            }
            //        }
            //    }
            //}

            //if (min_index_i > max_index_i)
            //{
            //    for (int i = max_index_i; i <= min_index_i; i++)
            //    {
            //        for (int j = 0; j < arr.GetLength(0); j++)
            //        {
            //            if (i == max_index_i && j > max_index_j)
            //            {
            //                sum += arr[i, j];
            //            }
            //            else if (i > max_index_i && i < min_index_i)
            //            {
            //                sum += arr[i, j];
            //            }
            //            else if (i == min_index_i && j < min_index_j)
            //            {
            //                sum += arr[i, j];
            //            }
            //        }
            //    }
            //}

            //if (min_index_i == max_index_i)
            //{
            //    if (min_index_j < max_index_j)
            //    {
            //        for (int j = min_index_j + 1; j < max_index_j; j++)
            //        {
            //            sum += arr[min_index_i, j];
            //        }
            //    }
            //}

            //if (min_index_i == max_index_i)
            //{
            //    if (min_index_j > max_index_j)
            //    {
            //        for (int j = max_index_j + 1; j < min_index_j; j++)
            //        {
            //            sum += arr[min_index_i, j];
            //        }
            //    }
            //}

            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine(sum);



        }
    }
}
    

