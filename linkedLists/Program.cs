using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace linkedLists
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<String> my_list = new LinkedList<string>();
            
            my_list.AddLast("Chicken");
            my_list.AddLast("BlueJay");
            my_list.AddLast("Cardinal");
            
            foreach (string str in my_list)
            {
               Console.WriteLine(str); 
            }
        }
        
    }
}