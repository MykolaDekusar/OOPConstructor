using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConstructor
{
    internal class Customer
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Number { get; set; }

        public Customer(string name, string address, string number) {
            Name = name;
            Address = address;  
            Number = number;
            Console.WriteLine($"Aggiunto cliente {Name} con indirizzo {Address} e telefono {Number}");
            
        }

        public Customer(string name, string address)
        {
            Name = name;
            Address = address;
            Console.WriteLine($"Aggiunto cliente {Name} con indirizzo {Address} e telefono sconosciuto");
        }
        public Customer(string name)
        {
            Name = name;
            Console.WriteLine($"Aggiunto cliente {Name} con indirizzo sconosciuto e telefono sconosciuto");
        }
        //Default constructor
        public Customer() {
            Name = "Unknown";
            Address = "Unknown";
            Number = "Unknown";
        }

    }
}
