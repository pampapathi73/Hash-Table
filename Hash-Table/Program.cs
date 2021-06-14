using System;

namespace Hash_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WelCome to hash table");
            MyMapNode<string, string> hash = new MyMapNode<string, string>(5);
            hash.Add("0", "To");
            hash.Add("1", "be");
            hash.Add("2", "or");
            hash.Add("3", "not");
            hash.Add("4", "to");
            hash.Add("5", "be");
            string hash2 = hash.Get("2");
            Console.WriteLine("The value for second index is: {0} ", hash2);
            string hash1 = hash.Get("1");
            Console.WriteLine("The value for First index is: {0} ", hash1);
        }
    }
    }

