/*
Given an array a that contains only numbers in the range 
from 1 to a.length, find the first duplicate number for which 
the second occurrence has the minimal index. In other words, 
if there are more than 1 duplicated numbers, return the number 
for which the second occurrence has a smaller index than the 
second occurrence of the other number does. If there are no 
such elements, return -1.
 */


using System;
using System.Collections.Generic;

namespace firstDup
{
    class firstDuplicate
    {
        static void Main(string[] args)
        {
            //test1
            int[] test1 = { 2, 1, 3, 5, 3, 2 };
            int test1Ans = firstDuplicateNum(test1);
            Console.WriteLine("Test1: " + test1Ans);
            Console.WriteLine("Test1 Expected: 3\n");

            //test2
            int[] test2 = { 2, 4, 3, 5, 1 };
            int test2Ans = firstDuplicateNum(test2);
            Console.WriteLine("Test2: " + test2Ans);
            Console.WriteLine("Test2 Expected: -1\n");

            //test3
            int[] test3 = { 1 };
            int test3Ans = firstDuplicateNum(test3);
            Console.WriteLine("Test3: " + test3Ans);
            Console.WriteLine("Test3 Expected: -1\n");

            //test4
            int[] test4 = { 2, 2 };
            int test4Ans = firstDuplicateNum(test4);
            Console.WriteLine("Test4: " + test4Ans);
            Console.WriteLine("Test4 Expected: 2\n");

            //test5
            int[] test5 = { 2, 1 };
            int test5Ans = firstDuplicateNum(test5);
            Console.WriteLine("Test5: " + test5Ans);
            Console.WriteLine("Test5 Expected: -1\n");

            //test6
            int[] test6 = { 2, 1, 3 };
            int test6Ans = firstDuplicateNum(test6);
            Console.WriteLine("Test6: " + test6Ans);
            Console.WriteLine("Test6 Expected: -1\n");

            //test7
            int[] test7 = { 2, 3, 3 };
            int test7Ans = firstDuplicateNum(test7);
            Console.WriteLine("Test7: " + test7Ans);
            Console.WriteLine("Test7 Expected: 3\n");

            //test8
            int[] test8 = { 3, 3, 3 };
            int test8Ans = firstDuplicateNum(test8);
            Console.WriteLine("Test8: " + test8Ans);
            Console.WriteLine("Test8 Expected: 3\n");

            //test9
            int[] test9 = { 8, 4, 6, 2, 6, 4, 7, 9, 5, 8 };
            int test9Ans = firstDuplicateNum(test9);
            Console.WriteLine("Test9: " + test9Ans);
            Console.WriteLine("Test9 Expected: 6\n");

            //test10
            int[] test10 = { 10, 6, 8, 4, 9, 1, 7, 2, 5, 3 };
            int test10Ans = firstDuplicateNum(test10);
            Console.WriteLine("Test10: " + test10Ans);
            Console.WriteLine("Test10 Expected: -1\n");

            //test11
            int[] test11 = { 1, 1, 2, 2, 1 };
            int test11Ans = firstDuplicateNum(test11);
            Console.WriteLine("Test11: " + test11Ans);
            Console.WriteLine("Test11 Expected: 1\n");

        }

        static int firstDuplicateNum(int[] a)
        {

            int index = 0;
            int dupIndex = -1;

            //initialize empty hashset to store first occurence of integer and add in finding duplicate integer
            HashSet<int> set = new HashSet<int>();

            //traverse array for integers
            for (index = 0; index < a.Length; index++)
            {

                //duplicate integer found
                if (set.Contains(a[index]))
                {
                    //first found duplicate
                    if (dupIndex == -1)
                    {
                        dupIndex = a[index];
                        break; //found first duplicate set, no need to continue
                    }
                }
                //new integer to be added to hashset
                else
                {
                    set.Add(a[index]);
                }
            }

            return (dupIndex);
        }
    }
}