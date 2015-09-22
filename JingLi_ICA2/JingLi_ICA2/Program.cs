using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JingLi_ICA2
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 5;
            args = new string[2];
            args[0] = number.ToString();
            string x = Console.ReadLine();
            args[0] = (x[0].ToString());
            x = x.Substring(1, x.Length - 2);
            //Console.WriteLine(x);
            args[1] = x;
            //Console.WriteLine(args[0]);
            //Console.WriteLine(args[1]);
            //Console.ReadKey();
            //args = x.Split((string[])null, StringSplitOptions.RemoveEmptyEntries);
            try
            {
                for (int i = 0; i < Convert.ToInt64(args[0]); i++)


                    Console.WriteLine(args[1]);

            }
            catch (Exception)
            {
                Console.WriteLine("Print error");
            }
            Console.ReadKey();
        }
    }
}
