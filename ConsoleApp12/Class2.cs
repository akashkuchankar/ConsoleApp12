using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    internal class Class2
    {
        static void Main(string[] args)
        {
            double[] rainfall = new double[7];
            for(int i = 0; i <rainfall.Length; i++)  
            {
                rainfall[i]=Convert.ToDouble(Console.ReadLine());

            }
            for(int i=0; i < rainfall.Length; i++)
            {
                Console.WriteLine($"rainfall[{i}]={rainfall[i]}"); 
            }
          
        }
    }
}
