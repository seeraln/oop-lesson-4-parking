using System;
using System.Collections.Generic;
using System.Text;

namespace oop_lesson_4_parking.models
{
    public class Customer
    {
        //public int hoursParked { get; set; }
        public int hoursparked { get; set; }
        public string registration { get; set; }
        public Customer(string _registration, int _hoursparked)
        {
            Console.WriteLine("I am the Customer");
            registration = _registration;
            hoursparked = _hoursparked;
        }

      

        public override string ToString()
        {
            return "I am the Customer";
        }
    }
}
