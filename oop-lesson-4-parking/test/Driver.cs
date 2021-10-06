using oop_lesson_4_parking.models;
using System;
using System.Collections.Generic;
using System.Text;

namespace oop_lesson_4_parking.test
{
    class Driver
    {
        public Driver()
        {
            Console.WriteLine("I am the code driver");
        }

        public void CreateObjects()
        {
            CarPark carpark = new CarPark();

            carpark.listOfCustomers.Add(new Customer("a", 2));
            carpark.listOfCustomers.Add(new Customer("b", 3));
            carpark.listOfCustomers.Add(new Customer("c", 4));
            carpark.listOfCustomers.Add(new Customer("d", 5));
            carpark.listOfCustomers.Add(new Customer("e", 6));
            carpark.listOfCustomers.Add(new Customer("f", 7));

            carpark.CalcuateCharges();

            CarParkCharge cpc = new CarParkCharge();
            Customer customer = new Customer("g", 8);

            Console.WriteLine(carpark.ToString());
            Console.WriteLine(cpc.ToString());
            Console.WriteLine(customer.ToString());
        }

       
    
    }
}
