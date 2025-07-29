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
        private string _brand = "";
        //constructor
        public Car(string brand, string modello) {
            _modello = modello;
            _brand = brand;
            Console.WriteLine($"Ho creato una macchina {_brand} {_modello}");
        }
    }
}
