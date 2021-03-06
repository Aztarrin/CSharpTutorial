﻿//As near as I can tell, using is the C# version of #include. Then again, C++ also has using statements. I typically
//avoided them (I would have used namespace std, but opted for std:: to access particular functions that came in the standard
//library)
//Maybe using does both in the same line.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//I'm still not sure about namespaces. They are similar to libraries, but not quite the same.
namespace CSharpTutorialOne
{
    //While C++ allows you to use classes, C# seems to demand it. I can kind of see the advantages.
    //Because everything is contained in a class, I'm not sure if you can have function prototypes like in C++
    //There are pointers like in C++, but they are apparently considered unsafe.
    //Admittedly pointers are dangerous in C++ too.
    class Program
    {
        //just like anything else, this is the main thread, hence the name Main
        static void Main(string[] args)
        {

            int i = 42;
            float f = 3.141f;
            double d = 3.141592653;
            bool b = true;

            int userBase;
            double userHeight;
            double triangleArea;
            int intTriangleArea;
            char userSelect;
            bool displayDataTypes = true;

            //How big is a char
            Console.Write("a char is {0} bytes\n", sizeof(char));
            //How big is a int
            Console.Write("a int is {0} bytes\n", sizeof(int));
            //How big is a float
            Console.Write("a float is {0} bytes\n", sizeof(float));
            //Console.ReadKey();

            /* C# has a few reference data types that refer to memory locations.
             * I'm not sure how these differ from pointers
             * Objects are base class reference variables, and must be converted before being used
             * Dynamics are similar, but can be changed at runtime
             * Strings seem to be just like the strings I am used to*/

            /* Let's play around with some builtin conversion methods
             * Let's throw some control loops in there, just for fun
             */
            do
            {
                Console.WriteLine("What do you want so see?");
                Console.WriteLine("(i) int");
                Console.WriteLine("(f) float");
                Console.WriteLine("(d) double");
                Console.WriteLine("(b) bool");
                Console.WriteLine("(n) nothing, I want to leave");
                 userSelect = Convert.ToChar(Console.ReadLine());//note to self: tried to use readKey, but I don't think readKey returns a value
                switch (userSelect)
                {
                    case 'i':
                        Console.WriteLine(i.ToString());
                    break;
                    case 'f':
                        Console.WriteLine(f.ToString());
                    break;
                    case 'd':
                        Console.WriteLine(d.ToString());
                    break;
                    case 'b':
                        Console.WriteLine(b.ToString());
                    break;
                    case 'n':
                        displayDataTypes = false;
                    break;
                }
            }
            while (displayDataTypes);

            Console.WriteLine("let's find the area of a triangle");
            Console.WriteLine("enter the base as an integer");
            userBase = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the height as a float");
            userHeight = Convert.ToDouble(Console.ReadLine());
            triangleArea = (double)userBase * userHeight;
            Console.WriteLine(triangleArea.ToString());
            intTriangleArea = userBase * (int)userHeight;
            Console.WriteLine(intTriangleArea.ToString());
            Console.ReadKey();

        }
    }
}
