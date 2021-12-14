using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to HashTable Project");
            MyMapNode<int, string> hash = new MyMapNode<int, string>(5);
            hash.Add(0, "to");
            hash.Add(1, "be");
            hash.Add(2, "or");
            hash.Add(3, "not");
            hash.Add(4, "to");
            hash.Add(5, "be");
            Console.WriteLine("Frequency of words in sentence are :");
            hash.FindFrequency("to");
            hash.FindFrequency("be");
            hash.FindFrequency("or");
            hash.FindFrequency("not");
            Console.ReadKey();
        }
    }
}
