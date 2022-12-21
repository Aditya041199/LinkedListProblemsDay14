using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            list.Addnote(56);
            //list.Addnote(30);
            list.Addnote(70);


            list.Insert(2, 30);
            list.Display();



        }
    }
}