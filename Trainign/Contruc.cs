using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trainign
{
    internal class Contruc
    {



        internal Contruc()//empty contructor, this is created autumatically when we create a new instance, example  "Construc con = new Contruct();"
        {
            Console.WriteLine("Contructor whitout params");
        }

        internal Contruc(string value1)// we may declare a constructor with 1 param.
        {
            Console.WriteLine("Value 1: " + value1);
        }        

        internal Contruc(string value1,string value2) : this(value1)// we may create overloading constreuctor also.
        {
            Console.WriteLine(" Value 2: "+value2);
        }

    }
}
