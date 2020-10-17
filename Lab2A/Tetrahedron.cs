//Name and student number: Eunjoo Na, 000811369
//File date : 2020.10.11
//Program's purpose: show the calculation of the shape according to the user's choice. 
//I, Eunjoo Na, 000811369 certify that this material is my original work.  
//No other person's work has been used without due acknowledgement.

using System;

namespace Lab2A
{
    /// <summary>
    /// This class is the Tetrahedron class in the program 
    /// </summary>
    class Tetrahedron : Shape
    {
        //length for Tetrahedron's length
        private double length;

        /// <summary>
        /// Tetrahedron constructor 
        /// </summary>
        public Tetrahedron() 
        {
            Type = "Tetrahedron";
            SetData();
        }


        /// <summary>
        /// Length manual property
        /// </summary>
        public double Length 
        {
            get { return length; }
            private set
            {
                //if the value is less than 0,  set the value as 0
                if (value > 0)
                    length = value;
                else
                    length = 0;
            }
        }

        /// <summary>
        /// CalculateArea method for the area
        /// </summary>
        /// <returns>result of the area calculation</returns>
        public override double CalculateArea()
        {
            return Math.Sqrt(3) * (length * length);
        }

        /// <summary>
        /// CalculateVolume method for the volume
        /// </summary>
        /// <returns>result of the volume calculation</returns>
        public override double CalculateVolume()
        {
            return Math.Pow(length, 3) / (6 * Math.Sqrt(2));
           
        }

        /// <summary>
        /// SetData method for getting the data from the user
        /// </summary>
        public override void SetData()
        {
            //get the length data from the user
            Console.Write("\nEnter the length:  ");
            string inputLength = Console.ReadLine();
            double lengthResult;

            //validate the user's input
            while (double.TryParse(inputLength, out lengthResult) == false)
            {
                Console.WriteLine("\nNumber is only accepted.");
                Console.Write("Enter the length:  ");
                inputLength = Console.ReadLine();
            }
            //set the length as lengthResult
            Length = lengthResult;
        }

        /// <summary>
        /// ToString method for the shape's calcultaion output
        /// </summary>
        /// <returns>shape's calcultaion result</returns>
        public override string ToString()
        {
            //detail instance for the detail information of the calculation
            string detail = $"{length,2:f} l";
            return $"{Type,-11} {CalculateArea(),11:f} {CalculateVolume(),11:f}  {detail,-44}";
        }

    }
}
