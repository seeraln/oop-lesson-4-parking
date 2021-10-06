using System;
using System.Collections.Generic;
using System.Text;

namespace oop_lesson_4_parking.models
{
    public class CarPark
    {
        public List<Customer> listOfCustomers = new List<Customer>();

        public CarParkCharge carParkCharge = new CarParkCharge();
        public CarPark()
        {
            Console.WriteLine("I am the carpark");
        }

        public override string ToString()
        {
            return "I am the carpark";
        }

        public void CalcuateCharges()
        {
            foreach(Customer customer in listOfCustomers)
            {
                int calculatedcharge = carParkCharge.CalculateCharge(customer.hoursparked);
                Console.WriteLine($"calculating charge for customer cost is {calculatedcharge}");
            }
        }
    }
}
