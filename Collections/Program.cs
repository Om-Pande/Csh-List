using System;
using System.Collections;

namespace Collections
{
 
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ArrayList is the same as Array except that its size increases dynamically.An ArrayList can be used to add unknown data where you don't know the types and the size of the data.");

            ArrayList arlist1 = new ArrayList();
            arlist1.Add(1);
            arlist1.Add("Bill");
            arlist1.Add(" ");
            arlist1.Add(true);
            arlist1.Add(4.5);
            arlist1.Add(null);

            foreach(var i in arlist1) { 
                Console.WriteLine(i);
            }

            Console.ReadKey();
        }

    }
}
