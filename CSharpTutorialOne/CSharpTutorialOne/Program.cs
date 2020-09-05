//As near as I can tell, using is the C# version of #include. Then again, C++ also has using statements. I typically
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
            //How big is a char
            Console.Write("a char is {0} bytes\n", sizeof(char));
            //How big is a int
            Console.Write("a int is {0} bytes\n", sizeof(int));
            //How big is a float
            Console.Write("a float is {0} bytes\n", sizeof(float));
            Console.ReadKey();

            /* C# has a few reference data types that refer to memory locations.
             * I'm not sure how these differ from pointers
             * Objects are base class reference variables, and must be converted before being used
             * Dynamics are similar, but can be changed at runtime
             * Strings seem to be just like the strings I am used to*/

            /* Let's play around with some builtin conversion methods
             */

            int i = 42;
            float f = 3.141592653f;
            double d = 3.141592653f;
            bool b = true;

          
            Console.WriteLine(i.ToString());
            Console.WriteLine(f.ToString());
            Console.WriteLine(d.ToString());
            Console.WriteLine(b.ToString());
            Console.ReadKey();

        }
    }
}
