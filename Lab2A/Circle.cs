//Name and student number: Eunjoo Na, 000811369
//File date : 2020.10.11
//Program's purpose: show the calculation of the shape according to the user's choice. 
//I, Eunjoo Na, 000811369 certify that this material is my original work.  
//No other person's work has been used without due acknowledgement.

using System;


namespace Lab2A
{
    /// <summary>
    /// This class is the Circle class in the program 
    /// </summary>
    class Circle : Shape
    {
        //radius for Circle's radius
        private double radius;

        /// <summary>
        /// Circle constructor
        /// </summary>
        public Circle() 
        {
            Type = "Circle";
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
        /// CalculateArea method for the area
        /// </summary>
        /// <returns>result of the area calculation</returns>
        public override double CalculateArea()
        {
            return PI * Math.Pow(radius,2);
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
            //get the radius data from the user
            Console.Write("\nEnter the radius:  ");
            string inputRadius = Console.ReadLine();
            double radiusResult;

            //validate the user's input
            while (double.TryParse(inputRadius, out radiusResult) == false)
            {
                Console.WriteLine("\nNumber is only accepted.");
                Console.Write("Enter the length:  ");
                inputRadius = Console.ReadLine();
            }

            //set the radius as radiusResult
            Radius = radiusResult;
        }

        /// <summary>
        /// ToString method for the shape's calcultaion output
        /// </summary>
        /// <returns>shape's calcultaion result</returns>
        public override string ToString()
        {
            //detail instance for the detail information of the calculation
            string detail = $"{radius,2:f} r";
            return $"{Type,-11} {CalculateArea(),11:f} { " ",11:f}  {detail,-44}";
        }

    }
}
