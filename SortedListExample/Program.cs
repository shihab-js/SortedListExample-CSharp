using System;
using System.Collections.Generic;

namespace SortedListExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //create a sorted list
            SortedList<int, string> names = new SortedList<int, string>();

            //add elements
            names.Add(2, "Mishu");
            names.Add(3, "Mithila");
            names.Add(1, "Shihab");
            names.Add(4, "Rayhan");

        }
    }
}
