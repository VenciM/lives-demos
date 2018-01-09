using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace passedOrGrade
{
   public class Program
    {
        public static void Main(string[] args)
        {

            double num = double.Parse(Console.ReadLine());

            if (num>2 & num<=6)
            {
                Console.WriteLine("{0} passed with: ", num);
                   
            }
            else
            {
                Console.WriteLine("grade");
            }
        }
    }
}
