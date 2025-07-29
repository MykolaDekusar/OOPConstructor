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
        //proprietà
        public string Modello { get => _modello; set => _modello = value; }
        public string Brand { get => _brand; set => _brand = value; }
        //constructor
        public Car(string brand, string modello) {
            Modello = modello;
            Brand = brand;
            Console.WriteLine($"Ho creato una macchina {Brand} {Modello}");
        }

        
    }
}
