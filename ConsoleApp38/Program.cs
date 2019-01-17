using System;

namespace ConsoleApp38
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new Lion();
            a.Eat();
            Console.ReadLine();
        }
    }

    class Jungle { }

    class Feline
    {
        public void init() {
            Jungle Home = new Jungle(); }

        public void Eat() { Console.WriteLine("I am eating"); }
    }

    class Lion : Feline
    {

    }

    class Tiger : Feline
    {

    }
}
