﻿using System;

namespace CsharpSolutions.Exercises.Task14
{
    //Abstract class
    abstract class Vehicle
    {
        //protected variable
        protected int tires;

        //Standard constructor
        public Vehicle()
        {

        }

        //Copy constructor
        public Vehicle(Vehicle vehicle)
        {
            this.tires = vehicle.tires;
        }

        //Get-Property for the variable
        public int Tire
        {
            get { return tires; }
        }

        //Some abstract methods
        public abstract void Accelerate();

        public abstract void Brake();

        //... and a virtual one!
        public virtual void Drive()
        {
            Console.WriteLine("Driving the vehicle!");
        }
    }
}
