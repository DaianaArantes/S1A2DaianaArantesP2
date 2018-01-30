/*
 * Program ID: A2DaianaArantesP2
 * 
 * Purpose: Create at least three methods to calculate 
 * volume of three objects: sphere, cylinder, and rectangular prism
 * 
 * Revision History
 * 
 * Written Oct 2017 by Daiana Arantes
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2DaianaArantesP2
{
    class Program
    {
        public static double pi = 3.14159;

        static void Main(string[] args)
        {
            //Declarating
            int typeOfShape = 0;
            double radius = 0;
            double volume = 0;
            double height = 0;
            double length = 0;
            double width = 0;

            //Initialize
            Console.WriteLine("What type of shape would you like to calculate the volume? ");
            Console.WriteLine();
            Console.WriteLine("Type 1 for Sphere ");
            Console.WriteLine("Type 2 for Cylinder ");
            Console.WriteLine("Type 3 for Rectangular Prism ");
            Console.WriteLine();

            do
            {
                //Try.Parse to validate if the input is valid
                if (!int.TryParse(Console.ReadLine(), out typeOfShape))
                {
                    Console.WriteLine("Invalid option, please enter 1, 2 or 3");
                    Console.WriteLine();
                }
                //Validate id the input is 1, 2 or 3 before while
                else if (typeOfShape > 3 || typeOfShape < 1)
                {
                    Console.WriteLine("Invalid option, please enter 1, 2 or 3");
                    Console.WriteLine();
                }
            } while (typeOfShape > 3 || typeOfShape < 1);


            switch (typeOfShape)
            {
                //If the user input 1 = sphere, then ask for parameters
                case 1:

                    do
                    {
                        Console.WriteLine("Please insert the radius of the Sphere" +
                            " in centimeters, for example 1.87: ");
                        Console.WriteLine();

                        //validade if the input is valid
                        if (!double.TryParse(Console.ReadLine(), out radius))
                        {
                            Console.WriteLine("Invalid input, please insert radius " +
                                "of sphere in centimeters: ");
                            Console.WriteLine();
                        }

                        else if (radius <= 0)
                        {
                            Console.WriteLine("Invalid input, please insert radius " +
                                "greater than 0 in centimeters: ");
                            Console.WriteLine();
                        }
                    } while (radius <= 0);

                    volume = Program.CalculateVolume(radius);
                    Console.WriteLine("The volume of the Sphere is: " + volume + " cm");

                    break;

                //If the user input 2 = Cylinder, then ask for parameters
                case 2:

                    do
                    {
                        Console.WriteLine();
                        Console.WriteLine("Please insert the radius of the Cylinder" +
                            " in centimeters, for example 1.87: ");
                        Console.WriteLine();

                        //validade if the input is valid
                        if (!double.TryParse(Console.ReadLine(), out radius))
                        {
                            Console.WriteLine();
                            Console.WriteLine("Invalid input, please insert radius" +
                                " of sphere in centimeters: ");
                            Console.WriteLine();
                        }

                        else if (radius <= 0)
                        {
                            Console.WriteLine();
                            Console.WriteLine("Invalid input, please insert radius" +
                                " greater than 0 in centimeters: ");
                            Console.WriteLine();
                        }
                    } while (radius <= 0);


                    //if the first input is valid, than ask for the next one
                    do
                    {
                        Console.WriteLine();
                        Console.WriteLine("Please insert the height of the Cylinder" +
                            " in centimeters, for example 1.87:");
                        Console.WriteLine();

                        //validade if the input is valid
                        if (!double.TryParse(Console.ReadLine(), out height))
                        {
                            Console.WriteLine();
                            Console.WriteLine("Invalid input, please insert height" +
                                " of cylinder in centimeters: ");
                            Console.WriteLine();
                        }

                        else if (height <= 0)
                        {
                            Console.WriteLine();
                            Console.WriteLine("Invalid input, please insert height" +
                                " greater than 0 in centimeters: ");
                            Console.WriteLine();
                        }
                    } while (height <= 0);

                    volume = Program.CalculateVolume(radius, height);
                    Console.WriteLine("The volume of the Cylinder is: " + volume + " cm");

                    break;

                //If the user input 3 = Retangular Prism, then ask for parameters
                case 3:

                    do
                    {
                        Console.WriteLine();
                        Console.WriteLine("Please insert the length of the Retangular" +
                            " Prism in centimeters, for example 1.87: ");
                        Console.WriteLine();

                        if (!double.TryParse(Console.ReadLine(), out length))
                        {
                            Console.WriteLine();
                            Console.WriteLine("Invalid input, please insert length " +
                                "of Retangular Prism in centimeters: ");
                            Console.WriteLine();
                        }

                        else if (length <= 0)
                        {
                            Console.WriteLine();
                            Console.WriteLine("Invalid input, please insert length " +
                                "greater than 0 in centimeters: ");
                            Console.WriteLine();
                        }
                    } while (length <= 0);


                    //if the first input is valid, than ask for the next one
                    do
                    {
                        Console.WriteLine();
                        Console.WriteLine("Please insert the width of the Retangular " +
                            "Prism in centimeters, for example 1.87: ");
                        Console.WriteLine();

                        if (!double.TryParse(Console.ReadLine(), out width))
                        {
                            Console.WriteLine();
                            Console.WriteLine("Invalid input, please insert width " +
                                "of Retangular Prism in centimeters: ");
                            Console.WriteLine();
                        }
                        else if (width <= 0)
                        {
                            Console.WriteLine();
                            Console.WriteLine("Invalid input, please insert width " +
                                "greater than 0 in centimeters: ");
                            Console.WriteLine();
                        }
                    } while (width <= 0);

                    //if the second input is valid, than ask for the next one
                    do
                    {
                        Console.WriteLine();
                        Console.WriteLine("Please insert the height of the Retangular " +
                            "Prism in centimeters, for example 1.87: ");
                        Console.WriteLine();

                        if (!double.TryParse(Console.ReadLine(), out height))
                        {
                            Console.WriteLine();
                            Console.WriteLine("Invalid input, please insert height of " +
                                "Retangular Prism in centimeters: ");
                            Console.WriteLine();
                        }

                        else if (height <= 0)
                        {
                            Console.WriteLine();
                            Console.WriteLine("Invalid input, please insert height greater" +
                                " than 0 in centimeters: ");
                            Console.WriteLine();
                        }
                    } while (height <= 0);

                    //calculate the volume of the Retangular Prism
                    volume = Program.CalculateVolume(length, width, height);
                    Console.WriteLine("The volume of the Retangular Prism is: " + volume + " cm");

                    break;
            }
        }

        //Calculate the volume of a sphere
        public static double CalculateVolume(double radius)
        {
            double sphereVolume = 4.00 / 3.00 * pi * Math.Pow(radius, 3);
            return sphereVolume;
        }

        //Calculate the volume of a cylinder
        public static double CalculateVolume(double radius, double height)
        {
            double cylinderVolume = pi * Math.Pow(radius, 2) * height;
            return cylinderVolume;
        }

        //Calculate the volume of a rectangular prism
        public static double CalculateVolume(double length, double width, double height)
        {
            double rectangularPrismVolume = length * width * height;
            return rectangularPrismVolume;
        }
    }
}