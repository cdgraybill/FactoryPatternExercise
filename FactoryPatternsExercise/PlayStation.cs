using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternsExercise
{
    class PlayStation : ICallable
    {
        public void Create()
        {
            Console.WriteLine("Creating a PlayStation!");
        }
    }
}
