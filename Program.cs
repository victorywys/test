using System;

namespace CsharpLearning
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    class BaoTest
    {
        public BaoTest(int id, string name)
        {
            this.ID = id;
            this.name = name;
        }
   

        public  int ID { get; set; }
        public string name { get; set; }
    }
}
