using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Homework
{
    class Client
    {
        public string Name { get; set; }
        public string PhoneNumber { get; set; }

        public Client(string Name, string PhoneNumber)
        {
            this.Name = Name;
            this.PhoneNumber = PhoneNumber;
        }

        public override string ToString()
        {
            return $"Ім'я: {this.Name}\nНомер телефону: {this.PhoneNumber}";
        }
    }
}
