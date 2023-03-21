using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp79
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "Бам бум бим бам";
            string[] bam = text.Split(' ');

            foreach (string bamLine in bam)
            {
                Console.WriteLine(bamLine);
            }
        }
    }
}
