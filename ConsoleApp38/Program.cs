using System;

namespace ConsoleApp38
{
    class Program1
    {
        static void Main(string[] args)
        {
            var a = new Lion();
            a.Eat();
            Console.ReadLine();
        }
    }

    class Jungle
    {
        Jungle Home;
        public void init()
        {
            Home = new Jungle();
        }
    }

    class Feline
    {
        public void Eat() { Console.WriteLine("I am eating"); }
    }

    class Lion : Feline
    {

    }

    class Tiger : Feline
    {

    }
}
