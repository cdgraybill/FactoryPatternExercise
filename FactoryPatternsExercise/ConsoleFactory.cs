using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternsExercise
{
    static class ConsoleFactory
    {
        public static ICallable GetConsole(string consoleType)
        {
            switch (consoleType.ToLower())
            {
                case "xbox":
                    return new Xbox();
                case "playstation":
                    return new PlayStation();
                case "switch":
                    return new Switch();
                default:
                    return new Default(); 
            }
        }
    }
}
