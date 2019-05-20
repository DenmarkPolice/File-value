using System;
using System.IO;
using System.Diagnostics;

namespace CodeFile1
{

    class RunArray
    {

        static void Main()
        {
            var WriteConsole = new WriteConsole();
            WriteConsole.Array();
        }
    }

    class WriteConsole
    {

        String[] arr = File.ReadAllLines("test.txt");
        public void Array()
        {
            arr[0] = ".";
            int counter = 0;

            while (counter < arr.Length)
            {
                if(arr[counter] != ".")
                {
                    Console.WriteLine(arr[counter]);
                }
                counter += 1;
            }
            Console.ReadKey(true);
        }
    }
}