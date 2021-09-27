using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CALCULATOR
{
    class Program
    {
        static void Main(string[] args)
        {//coded by:alimousavi   instagram:1_alimousavi_1   telegram: alimousavi_1
            while (true)
            {
                Console.WriteLine("*/*/*/*/*Calculator*/*/*/*/*");
                Console.WriteLine("Enter Your First Number = ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Your Second Number = ");
                int num2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please Enter Operation : ( * , / , + , - )");
                string opt = Console.ReadLine();
                int result = 0;
                if (opt == "*")
                    result = num1 * num2;
                else if (opt == "/")
                    result = num1 / num2;
                else if (opt == "+")
                    result = num1 + num2;
                else if (opt == "-")
                    result = num1 - num2;
                Console.WriteLine(" Your Result Is = {0}", result);
                Console.WriteLine("--------------------------------  Please Press Enter To Continue  ----------------------------------");
                Console.ReadKey();
            }


        }
    }
}
