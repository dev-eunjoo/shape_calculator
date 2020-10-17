//Name and student number: Eunjoo Na, 000811369
//File date : 2020.10.11
//Program's purpose: show the calculation of the shape according to the user's choice. 
//I, Eunjoo Na, 000811369 certify that this material is my original work.  
//No other person's work has been used without due acknowledgement.

using System;
using System.Collections.Generic;
using System.Linq;


namespace Lab2A
{   /// <summary>
    /// This class is the main class in the program and control the program
    /// </summary>
    class Program
    {

        /// <summary>
        /// Main method of the class and it controls the program
        /// </summary>
        /// <param name="args">optional parameters which are not used for this program</param>
        static void Main(string[] args)
        {
            // create shapes list to contains Shape objects
            List<Shape> shapes = new List<Shape>();

            //execute Collect method for collecting the shape
            Collect(shapes);
        }

        /// <summary>
        /// this method is about selecting shape on the menu 
        /// </summary>
        /// <param name="shapes">List of Shape</param>
        /// <returns>true</returns>
        private static bool Collect(List<Shape> shapes)
        {
            //diplay the menu option
            DisplayMenu();
            //exit for deciding exit or continue the program 
            bool exit = false;
            while (exit == false)
            {
                //get the input from the user
                string input = Console.ReadLine();

                //execute Choice method according to the user's input
                if (string.Equals(input.ToLower(), "a")) { Choice("Rectangle", shapes); Console.Clear(); DisplayMenu(); }
                else if (string.Equals(input.ToLower(), "b")) { Choice("Square", shapes); Console.Clear(); DisplayMenu(); }
                else if (string.Equals(input.ToLower(), "c")) { Choice("Box", shapes); Console.Clear(); DisplayMenu(); }
                else if (string.Equals(input.ToLower(), "d")) { Choice("Cube", shapes); Console.Clear(); DisplayMenu(); }
                else if (string.Equals(input.ToLower(), "e")) { Choice("Ellipse", shapes); Console.Clear(); DisplayMenu(); }
                else if (string.Equals(input.ToLower(), "f")) { Choice("Circle", shapes); Console.Clear(); DisplayMenu(); }
                else if (string.Equals(input.ToLower(), "g")) { Choice("Cylinder", shapes); Console.Clear(); DisplayMenu(); }
                else if (string.Equals(input.ToLower(), "h")) { Choice("Sphere", shapes); Console.Clear(); DisplayMenu(); }
                else if (string.Equals(input.ToLower(), "i")) { Choice("Triangle", shapes); Console.Clear(); DisplayMenu(); }
                else if (string.Equals(input.ToLower(), "j")) { Choice("Tetrahedron", shapes); Console.Clear(); DisplayMenu(); }
                else if (string.Equals(input, "0")) 
                {
                    Console.Clear();

                    // shapeNumber for count of shapes in the list
                    int shapeNumber = shapes.Count();

                    //execute  DisplayTitle method to display the title and the number of selected shape.
                    DisplayTitle(shapeNumber);

                    //execute  DisplayResult method to display the result of the calculation 
                    DisplayResult(shapes);
                    Console.Write("\nPress any key to exit : ");

                    //exitInput for exit 
                    string exitInput = Console.ReadLine();
                    if (exitInput != null) {exit = true;}
                }
                else
                {
                    //show the error and start again when the user input is invalid 
                    Console.WriteLine("\nThat is not a valid choice, please try again");
                    Console.Write("\nPress any key to continue . . .");
                    string continueInput = Console.ReadLine();
                    if (continueInput != null)
                    {
                        //clear the screen and show the display menu 
                        Console.Clear();
                        DisplayMenu();
                    }
                }

            }
            return true;
        }

        /// <summary>
        /// this method is for Displaying title
        /// </summary>
        /// <param name="shapeNumber">the number of the shapes in the list</param>
        private static void DisplayTitle(int shapeNumber)
        {
            Console.WriteLine("Nick's Geometry Class:");
            Console.WriteLine($"\nThere are {shapeNumber} objects: \n");
            Console.WriteLine("Shape        Area        Volume      Details                                 ");
            Console.WriteLine("===========  ==========  ==========  ========================================");
        }

        /// <summary>
        /// this method is for Displaying result
        /// </summary>
        /// <param name="shapes">List of Shape</param>
        private static void DisplayResult(List<Shape> shapes)
        {
            //show the result of the element in the shapes list
            foreach (Shape element in shapes)
            {
                Console.WriteLine(element.ToString());
            }
        }

        /// <summary>
        /// this method is for Displaying menu
        /// </summary>
        private static void DisplayMenu()
        {
            Console.WriteLine("Nick's Geometry Class:");
            Console.WriteLine("A - Rectangle     E - Ellipse     I - Triangle");
            Console.WriteLine("B - Square        F - Circle      J - Tetrahedron");
            Console.WriteLine("C - Box           G - Cylinder");
            Console.WriteLine("D - Cube          H - Sphere");
            Console.WriteLine("\n0 - List all shapes and Exit...");
            Console.WriteLine($"\nEnter your choice: ( {Shape.GetCount()} shapes entered so far)");
        }

        /// <summary>
        /// This method is for creating the shape and execute it acccording to the user's input 
        /// </summary>
        /// <param name="shape">user's input</param>
        /// <param name="shapes">List of Shape</param>
        private static void Choice(string shape, List<Shape> shapes)
        {
            //newShape for the selected shape 
            Shape newShape;

            //check the user's input
            if (shape == "Rectangle")
            {
                //assign the Rectangle
                newShape = new Rectangle();
                //add the shape in the shapes list
                shapes.Add(newShape);
            }
            else if (shape == "Square")
            {
                //assign the Square
                newShape = new Square();
                //add the shape in the shapes list
                shapes.Add(newShape);

            }
            else if (shape == "Box")
            {   //assign the Box
                newShape = new Box();
                //add the shape in the shapes list
                shapes.Add(newShape);
            }
            else if (shape == "Cube")
            {
                //assign the Cube
                newShape =  new Cube();
                //add the shape in the shapes list
                shapes.Add(newShape);
            }
            else if (shape == "Ellipse")
            {
                //assign the Ellipse
                newShape = new Ellipse();
                //add the shape in the shapes list
                shapes.Add(newShape);
            }
            else if (shape == "Circle")
            {
                //assign the Circle
                newShape = new Circle();
                //add the shape in the shapes list
                shapes.Add(newShape);
            }
            else if (shape == "Cylinder")
            {
                //assign the Cylinder
                newShape = new Cylinder();
                //add the shape in the shapes list
                shapes.Add(newShape);
            }
            else if (shape == "Sphere")
            {
                //assign the Sphere
                newShape = new Sphere();
                //add the shape in the shapes list
                shapes.Add(newShape);
            }
            else if (shape == "Triangle")
            {
                //assign the Triangle
                newShape = new Triangle();
                //add the shape in the shapes list
                shapes.Add(newShape);
            }
            else if (shape == "Tetrahedron")
            {
                //assign the Tetrahedron
                newShape = new Tetrahedron();
                //add the shape in the shapes list
                shapes.Add(newShape);
            }

        }
        }
    }

