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
    //There are definitely not pointers like in C++. I will need to learn how to work with that. This will be interesting.
    class Program
    {
        static void Main(string[] args)
        {
            //just like anything else, this is the main thread, hence the name Main
        }
    }
}
