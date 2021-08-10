using System;

namespace HashTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Hash Map");
            MyMapNode<string, string> hash = new MyMapNode<string, string>(5);

            hash.Add("0", "To");
            hash.Add("1", "be");
            hash.Add("2", "or");
            hash.Add("3", "not");
            hash.Add("4", "to");
            hash.Add("5", "be");

            string hash4 = hash.Get("4");
            Console.WriteLine("fourth index value : " + hash4);
            hash.Remove("1");
            string hash1 = hash.Get("1");
            Console.WriteLine("First index value:" + hash1);
        }
    }
    
}
