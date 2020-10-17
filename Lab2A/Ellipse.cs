//Name and student number: Eunjoo Na, 000811369
//File date : 2020.10.11
//Program's purpose: show the calculation of the shape according to the user's choice. 
//I, Eunjoo Na, 000811369 certify that this material is my original work.  
//No other person's work has been used without due acknowledgement.

using System;


namespace Lab2A
{
    /// <summary>
    /// This class is the Ellipse class in the program 
    /// </summary>
    class Ellipse : Shape
    {
        //major for Ellipse's semi-major
        private double major;
        //minor for Ellipse's minor
        private double minor;

        /// <summary>
        /// Ellipse constructor 
        /// </summary>
        public Ellipse() 
        {
            Type = "Ellipse";
            SetData();
        }


        /// <summary>
        /// Major manual property
        /// </summary>
        public double Major
        {
            get { return major; }
            private set
            {
                //if the value is less than 0,  set the value as 0
                if (value > 0)
                    major = value;
                else
                    major = 0;
            }
        }

        /// <summary>
        /// Minor manual property
        /// </summary>
        public double Minor
        {
            get { return minor; }
            private set
            {
                //if the value is less than 0,  set the value as 0
                if (value > 0)
                    minor = value;
                else
                    minor = 0;
            }
        }

        /// <summary>
        /// CalculateArea method for the area
        /// </summary>
        /// <returns>result of the area calculation</returns>
        public override double CalculateArea()
        {
            return major * minor * PI;
        }

        /// <summary>
        /// CalculateVolume method for the volume
        /// </summary>
        /// <returns>throw NotImplementedException for not using volume method in this class </returns>
        public override double CalculateVolume()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// SetData method for getting the data from the user
        /// </summary>
        public override void SetData()
        {
            //get the semi-major data from the user
            Console.Write("\nEnter the semi-major axis length:   ");
            string inputMajor = Console.ReadLine();
            double majorResult;

            //validate the user's input
            while (double.TryParse(inputMajor, out majorResult) == false)
            {
                Console.WriteLine("\nNumber is only accepted.");
                Console.Write("Enter the length:  ");
                inputMajor = Console.ReadLine();
            }
            //set the major as majorResult
            Major = majorResult;

            //get the semi-minor data from the user
            Console.Write("\nEnter the semi-minor axis length: ");
            string inputMinor = Console.ReadLine();
            double minorResult;

            //validate the user's input
            while (!double.TryParse(inputMinor, out minorResult))
            {
                Console.WriteLine("\nNumber is only accepted.");
                Console.Write("Enter the width:  ");
                inputMinor = Console.ReadLine();
            }

            //set the minor as minorResult
            Minor = minorResult;
        }

        /// <summary>
        /// ToString method for the shape's calcultaion output
        /// </summary>
        /// <returns>shape's calcultaion result</returns>
        public override string ToString()
        {
            //detail instance for the detail information of the calculation
            string detail = $"{major,2:f} s.major x {minor,2:f} s.minor";
            return $"{Type,-11} {CalculateArea(),11:f} { " ",11:f}  {detail,-44}";
        }

    }
}
