using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternsExercise
{
    class Default : ICallable
    {
        public void Create()
        {
            Console.WriteLine("Creating a Commodore 64 since you wanna be stubborn...");
        }
    }
}
