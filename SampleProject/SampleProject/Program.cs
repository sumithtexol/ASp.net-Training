using System;
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

            
            Console.WriteLine("Enter an integer");
            int n = Convert.ToInt32(Console.ReadLine());
            
            for (int i = 1; i <= n; i++) 
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
            




        }

        
    }
}
