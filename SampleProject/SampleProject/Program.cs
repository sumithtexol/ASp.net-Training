﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleProject
{
    class Program
    {
        static void Main(string[] args)
        {

            Program p = new Program();
            p.ShowMessage();
            GetMessage();
            //Update Code here 

        }

        public void ShowMessage()
        {
            Console.WriteLine("Welcome");
        }
        public static void GetMessage()
        {
            Console.WriteLine("Hello World");
            Console.Read();
        }
    }
}
