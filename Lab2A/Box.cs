//Name and student number: Eunjoo Na, 000811369
//File date : 2020.10.11
//Program's purpose: show the calculation of the shape according to the user's choice. 
//I, Eunjoo Na, 000811369 certify that this material is my original work.  
//No other person's work has been used without due acknowledgement.

using System;


namespace Lab2A
{
    /// <summary>
    /// This class is the Box class in the program 
    /// </summary>
    class Box : Shape
    {
        //length for Box's length
        private double length;
        //width for Box's width
        private double width;
        //height for Box's height
        private double height;

        /// <summary>
        /// Box constructor
        /// </summary>
        public Box() 
        {
            Type = "Box";
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
        /// Width manual property
        /// </summary>
        public double Width
        {
            get { return width; }
            private set
            {
                //if the value is less than 0,  set the value as 0
                if (value > 0)
                    width = value;
                else
                    width = 0;
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
            return 2*(height * width) + 2*(height * length) + 2*(width * length);
        }

        /// <summary>
        /// CalculateVolume method for the volume
        /// </summary>
        /// <returns>result of the volume calculation</returns>
        public override double CalculateVolume()
        {
            return height * length * width;
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

            //get the width data from the user
            Console.Write("\nEnter the width:  ");
            string inputWidth = Console.ReadLine();
            double widthResult;

            //validate the user's input
            while (!double.TryParse(inputWidth, out widthResult))
            {
                Console.WriteLine("\nNumber is only accepted.");
                Console.Write("Enter the width:  ");
                inputWidth = Console.ReadLine();
            }
            //set the width as widthResult
            Width = widthResult;

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
            string detail = $"{length,2:f} l x {width,2:f} w x {height,2:f} h";
            return $"{Type,-11} {CalculateArea(),11:f} { CalculateVolume(),11:f}  {detail,-44}";
        }

    }
}