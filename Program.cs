using System;
using CCollections;
using System.Collections;
using System.Collections.Generic;
//gacutil /i

namespace Collections
{
    public delegate int addDel(int a, int b);
    class Program
    {
        public static void callDes()
        {
            if (true) { Program p = new Program(); }
        }
        public static void Main()
        {
            Console.WriteLine("Main function");
            callDes();
        }

    }
}