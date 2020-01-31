using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternsExercise
{
    class Switch : ICallable
    {
        public void Create()
        {
            Console.WriteLine("Creating a Switch!");
        }
    }
}
