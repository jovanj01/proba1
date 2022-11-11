using System;
using ZadatakV2.Model;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadatakV2
{
    class Program
    {
        static void Main(string[] args)
        {
            string broj = "";
            Console.WriteLine("Unesi broj:");
            broj = Console.ReadLine();

            if (broj.Contains("3"))
            {
                Console.WriteLine("Ima 3");
            }
            else
            {
                Console.WriteLine("Nema 3!");
            }
           

            Addition sabiranje = new Addition(1, 3);

            Console.WriteLine(sabiranje.saberi());

            Console.ReadKey();

        }
    }
}