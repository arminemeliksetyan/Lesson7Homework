using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7Homework
{
    internal class Car
    {
        public string model;
        public string marka;
        public int year;
        public float motor;
        public string color;
        public decimal price;

        public Car(string model, string marka, int year, float motor, string color, decimal price)
        {
            this.model = model;
            this.marka = marka;
            this.year = year;
            this.motor = motor;
            this.color = color;
            this.price = price;
        }

        public void Print()
        {
            Console.WriteLine("{0} {1} {2} {3} {4} ${5}", model, marka,year, motor,color, price);
        }


    }
}
