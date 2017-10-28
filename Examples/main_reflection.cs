// ICar.cs - Interface 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Reflection
{
    interface ICar
    {
        bool IsMoving();
    }
}

// Car.cs - Class 
using System; 
using System.Collections.Generic; 
using System.Linq; 
using System.Text; 

namespace Reflection
{
    internal class Car
    {
        //public variables 
        public string Color;

        //private variables 
        //String licensePlate; // e.g. "Californi 111 222" 
        //double maxSpeed;     // in kilometers per hour 
        //int startMiles; // Stating odometer reading 
        //int endMiles; // Ending odometer reading 
        //double gallons; // Gallons of gas used between the readings  

        //private vaiables 
        private int _speed;

        //Speed - read-only property to return the speed 
        public int Speed
        {
            get { return _speed; }
        }

        //Accelerate - add mph to the speed 
        public void Accelerate(int accelerateBy)
        {
            //Adjust the speed 
            _speed += accelerateBy;
        }

        //IsMoving - is the car moving? 
        public bool IsMoving()
        {
            //Is the car's speed zero? 
            if (Speed == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        //Constructor 
        public Car()
        {
            //Set the default values 
            Color = "White";
            _speed = 0;
        }

        //Over loaded constructor 
        public Car(string color, int speed)
        {
            Color = color;
            _speed = speed;
        }

        //methods 
        public double calculateMPG(int startMiles, int endMiles, double gallons)
        {
            return (endMiles - startMiles) / gallons;
        }
    }
}

// SportsCar.cs - Class 
using System; 
using System.Collections.Generic; 
using System.Linq; 
using System.Text; 

namespace Reflection
{
    internal class SportsCar : Car
    {
        //Constructor 
        public SportsCar()
        {
            //Change the default values 
            Color = "Green";
        }
    }
}