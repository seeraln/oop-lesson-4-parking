using System;
using System.Collections.Generic;
using System.Text;

namespace oop_lesson_4_parking.models
{
    public class CarParkCharge
    {
        public int minihours { get; set; }
        public int minimumfee { get; set; }
        

        public CarParkCharge(int _minimumfee=2, int _minihours=3)
        {
            Console.WriteLine("I am the CarParkCharge");
            minimumfee = _minimumfee;
            minihours = _minihours;
        }

        public override string ToString()
        {
            return "I am the CarParkCharge";
        }

        public int CalculateCharge(int hoursParked)
        {
            
            int calculatedfee = hoursParked < minihours ? minimumfee : hoursParked * minimumfee;
            return calculatedfee;
        }
    }
}
