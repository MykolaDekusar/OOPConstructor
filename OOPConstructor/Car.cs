using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConstructor
{
    internal class Car
    {
        //Se non dobbiamo modificare i field possiamo anche evitare di usarli nelle proprietà
        //private string _modello = "";
        private string _brand = "";
        //proprietà
        public string Modello { get; set; }
        public bool Luxury { get; set; }
        public string Brand {
            get
            {
                if (Luxury)
                {
                    return _brand + " - Edizione Luxury";
                }
                else
                {
                    return _brand;
                }
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("Non hai inserito un campo brand");
                    _brand = "DEFAULT";
                }
                else
                {
                    _brand = value;
                }
            }
        }
        //constructor
        public Car(string brand, string modello, bool luxury) {
            Modello = modello;
            Brand = brand;
            Luxury = luxury;
            Console.WriteLine($"Ho creato una macchina {Brand} {Modello}");
        }
        //Aggiungo altri costruttori che prendono solo brand e modello e solo brand
        public Car(string brand, string modello)
        {
            Modello = modello;
            Brand = brand;
            Console.WriteLine($"Ho creato una macchina {Brand} {Modello}");
        }

        public Car( string  brand)
        {
            Brand = brand;
            Console.WriteLine($"Ho creato una macchina {Brand}");
        }




    }
}
