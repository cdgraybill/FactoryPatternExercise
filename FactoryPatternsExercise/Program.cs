using System;

namespace FactoryPatternsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What kind of console do you want?");
            string userConsole = Console.ReadLine();

            ICallable console = ConsoleFactory.GetConsole(userConsole);
            console.Create();
            Console.ReadLine();
        }
    }
}
