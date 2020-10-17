﻿//Name and student number: Eunjoo Na, 000811369
//File date : 2020.10.11
//Program's purpose: show the calculation of the shape according to the user's choice. 
//I, Eunjoo Na, 000811369 certify that this material is my original work.  
//No other person's work has been used without due acknowledgement.

using System;


namespace Lab2A
{
    /// <summary>
    /// This class is the Cylinder class in the program 
    /// </summary>
    class Cylinder : Shape
    {
        //radius for Cylinder's radius
        private double radius;
        //height for Cylinder's height
        private double height;

        /// <summary>
        /// Cylinder constructor
        /// </summary>
        public Cylinder() 
        {
            Type = "Cylinder";
            SetData();
        }


        /// <summary>
        /// Radius manual property
        /// </summary>
        public double Radius
        {
            get { return radius; }
            private set
            {
                //if the value is less than 0,  set the value as 0
                if (value > 0)
                    radius = value;
                else
                    radius = 0;
            }
        }

        /// <summary>
        /// Height manual property
        /// </summary>
        public double Height
        {
            get { return height; }
            private set
            {
                //if the value is less than 0,  set the value as 0
                if (value > 0)
                    height = value;
                else
                    height = 0;
            }
        }

        /// <summary>
        /// CalculateArea method for the area
        /// </summary>
        /// <returns>result of the area calculation</returns>
        public override double CalculateArea()
        {
            return 2 * PI * ( radius*height + Math.Pow(radius, 2));
        }

        /// <summary>
        /// CalculateVolume method for the volume
        /// </summary>
        /// <returns>result of the volume calculation</returns>
        public override double CalculateVolume()
        {
            return PI * Math.Pow(radius, 2)*height;
        }

        /// <summary>
        /// SetData method for getting the data from the user
        /// </summary>
        public override void SetData()
        {
            //get the radius data from the user
            Console.Write("\nEnter the radius:  ");
            string inputRadius = Console.ReadLine();
            double radiusResult;
            double heightResult;

            //validate the user's input
            while (double.TryParse(inputRadius, out radiusResult) == false)
            {
                Console.WriteLine("\nNumber is only accepted.");
                Console.Write("Enter the radius:  ");
                inputRadius = Console.ReadLine();
            }

            //set the radius as radiusResult
            Radius = radiusResult;

            //get the radius data from the user
            Console.Write("\nEnter the height:  ");
            string inputHeight = Console.ReadLine();

            //validate the user's input
            while (!double.TryParse(inputHeight, out heightResult))
            {
                Console.WriteLine("\nNumber is only accepted.");
                Console.Write("Enter the height:  ");
                inputHeight = Console.ReadLine();
            }
            //set the height as radiusResult
            Height = heightResult;
        }

        /// <summary>
        /// ToString method for the shape's calcultaion output
        /// </summary>
        /// <returns>shape's calcultaion result</returns>
        public override string ToString()
        {
            //detail instance for the detail information of the calculation
            string detail = $"{radius,2:f} r x {height,2:f} h";
            return $"{Type,-11} {CalculateArea(),11:f} { CalculateVolume(),11:f}  {detail,-44}";
        }

    }
}
