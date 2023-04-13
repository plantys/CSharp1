﻿namespace BListsCompare {
    using System.Collections.Generic;
    using static System.Runtime.InteropServices.JavaScript.JSType;

    class Program {
        static void Main(string[] args) {

            // Declare and initialize a list of lists
                                        new List<int> { 1, 2, 3 },
                                        new List<int> { 7, 8, 9 }
                            // Add a new column to each row// Add a new element with value 0 to the end of the list
                            // Remove the second column from each row // Remove the element at index 1 (the second element)

            //ARRAY - Jagged
            int[][] myArray = new int[4][]
            {
                    new int[] {1, 2, 3},
                    new int[] {4, 5, 6},
                    new int[] {7, 8, 9},
                    new int[] {10, 11, 12}
            };

            //ARRAY - MultiDim
            int[,] myArray1 = new int[4, 3]
            {
                {1, 2, 3},
                {4, 5, 6},
                {7, 8, 9},
                {10, 11, 12}
            };

            //Compare lists
            List<int> list1 = new List<int> { 1, 2, 3, 4, 5 };
            List<int> list3 = new List<int> { 1, 2, 3, 4, 5 };
            bool result2 = list1.SequenceEqual(list3); // returns true
            Console.WriteLine(result2);
        }
