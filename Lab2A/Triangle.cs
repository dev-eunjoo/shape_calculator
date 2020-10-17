//File date : 2020.10.11
//Program's purpose: show the calculation of the shape according to the user's choice. 
//I, Eunjoo Na, 000811369 certify that this material is my original work.  
//No other person's work has been used without due acknowledgement.


using System;

namespace Lab2A
{
    /// <summary>
    /// This class is the Triangle class in the program 
    /// </summary>
    class Triangle : Shape
    {
        //triBase for Triangle's base
        private double triBase;
        //height for Triangle's height
        private double height;

        /// <summary>
        /// Triangle constructor 
        /// </summary>
        public Triangle() 
        {
            Type = "Triangle";
            SetData();
        }

        /// <summary>
        /// TriBase manual property
        /// </summary>
        public double TriBase
        {
            get { return triBase; }
            private set
            {
                //if the value is less than 0,  set the value as 0
                if (value > 0)
                    triBase = value;
                else
                    triBase = 0;
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
            return (triBase * height)/2;
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
            //get the base data from the user
            Console.Write("\nEnter the base:  ");
            string inputBase = Console.ReadLine();
            double baseResult;

            //validate the user's input
            while (double.TryParse(inputBase, out baseResult) == false)
            {
                Console.WriteLine("\nNumber is only accepted.");
                Console.Write("Enter the base:  ");
                inputBase = Console.ReadLine();
            }
            //set the triBase as baseResult
            TriBase = baseResult;

            //get the height data from the user
            Console.Write("\nEnter the height:  ");
            string inputHeight = Console.ReadLine();
            double heightResult;

            //validate the user's input
            while (!double.TryParse(inputHeight, out heightResult))
            {
                Console.WriteLine("\nNumber is only accepted.");
                Console.Write("Enter the height:  ");
                inputHeight = Console.ReadLine();
            }
            //set the height as heightResult
            Height = heightResult;
        }

        /// <summary>
        /// ToString method for the shape's calcultaion output
        /// </summary>
        /// <returns>shape's calcultaion result</returns>
        public override string ToString()
        {
            //detail instance for the detail information of the calculation
            string detail = $"{triBase,2:f} b x {height,2:f} h";
            return $"{Type,-11} {CalculateArea(),11:f} { " ",11:f}  {detail,-44}";
        }

    }
}

