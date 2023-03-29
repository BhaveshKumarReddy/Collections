using System;
using CCollections;
using System.Collections;
using System.Collections.Generic;

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
            //Stack st = new Stack();
            callDes();
            /*Program c = new Program();
            addDel ad3 = c.mulDel;
            Console.WriteLine(ad3(2,3));*/
        }
        /*
        static void Main(string[] args)
        {
            Employee e = new Employee(10,10,"");
            Console.WriteLine(e.add(10));

            int i, j, r;
            i = Convert.ToInt32(Console.ReadLine());
            j = Convert.ToInt32(Console.ReadLine());
            try
            {
                r = i / j;
                Console.WriteLine(r);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {

            }*/
             //Console.WriteLine(c.Eid);


            //Employee e = new Employee(1, 1000, "Bhavesh");
            //Console.WriteLine(e.Bonus());
            /*
            
            List<Employee> l = new List<Employee>();
            l.Add(new Employee(1,1000,"Bhavesh"));
            l.Add(new Employee(2, 2000, "Kumar"));
            l.Add(new Employee(3, 3000, "Reddy"));
            foreach(var v in l)
            {
                Console.WriteLine(v.Eid+"  "+v.Salary+"  "+v.Ename);
                Console.WriteLine(v.ToString());
            }

            Object[] o = new Object[4];
            o[0] = 1;
            o[3] = "Bhavesh";
            foreach (Object i in o)
            {
                Console.WriteLine(i);
            }
            
            List<int> l = new List<int>();
            l.Add(10);
            l.Add(20);
            l.RemoveAt(0);
            foreach(int i in l){
            Console.WriteLine(i);
            }
            
             Dictionary<int, string> d = new Dictionary<int, string>();
             d.Add(0,"Bhavesh");
             d.Add(1, "Kumar");
             d.Add(2, "Reddy");
             ICollection<int> it = d.Keys;
             foreach (int ok in it)
             {
              Console.WriteLine(ok);
             }
             foreach(KeyValuePair<int,string> k in d)
             {
              Console.Write(k+"  ");
              Console.WriteLine(k.Key+"  "+k.Value);
             }

             Stack<int> s = new Stack<int>();
             s.Push(10);
             s.Push(20);
             foreach(int i in s)
             {
                 Console.Write(i+" ");
             }
             
             Queue<int> q = new Queue<int>();
             q.Enqueue(10);
             q.Enqueue(20);
             foreach(int j in q)
             {
                 Console.Write(j+" ");
             }
             
             HashSet<int> s = new HashSet<int>();
             s.Add(10);
             s.Add(20);
             s.Add(10);
             foreach(int i in s)
             {
                 Console.Write(i+" ");
             }

             */



    }
}
/*

*/