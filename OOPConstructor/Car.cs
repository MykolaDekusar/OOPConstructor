using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConstructor
{
    internal class Car
    {
        private string _modello = "";
        public Car(string modello) {
            _modello = modello;
            Console.WriteLine("Ho creato una macchina con il modello: "+ _modello);
        }
    }
}
