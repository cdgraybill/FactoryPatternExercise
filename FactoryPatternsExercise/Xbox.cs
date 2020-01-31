using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternsExercise
{
    class Xbox : ICallable
    {
        public void Create()
        {
            Console.WriteLine("Creating an Xbox!");
        }
    }
}
