using System;
using System.Threading;

namespace EX2_Chien
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Chien");
            Console.WriteLine("----------------------------");
            Chien monchien = new Chien("médor", "21/01/2009", 10, 34, true);
            Console.WriteLine(monchien.Aboyer());
            Console.WriteLine(monchien.Sleeping());
            Console.WriteLine(monchien.Eat());
            Console.WriteLine("Chat");
            Console.WriteLine("----------------------------");
            Chat monChat = new Chat("Antoine", "21/02/2022", 12, 22, true);
            Console.WriteLine(monChat.Miauler());
            Console.WriteLine(monChat.Eat());
            Console.WriteLine(monChat.Ronronne());
            Console.WriteLine(monChat.Sleeping());
            Console.WriteLine("Chat");
            Console.WriteLine("----------------------------");
            Lapin monLapin = new Lapin("Ted", "21/01/2023", 13, 10, false, 30);
            Console.WriteLine(monLapin.Bonds());
            Console.ReadLine();
        }
    }
}
