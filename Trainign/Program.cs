using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Trainign
{
    internal class Program
    {

        struct Person { 
            public string Name;
            public int Age;
            public decimal Salary;
        }


        static void Main(string[] args)
        {

            //Topic1
            //Topic1();


            //Topic 2
                Topic2();
        }
        
        
        internal static void Topic2()
        {
            //Initializing Arrays
            int[] Num = new int[2] { 1, 2 };
            long[] lo = new long[2] { 123124124,1243124234};
            string[] Name = new string[3] { "Kevin", "juan", "Carlos" };
            float[] flo = new float[2] { 1.2f, 2.2f };
            decimal[] decimals = new decimal[2] { 125.15m, 124.45m };

            int[,] mulArr = new int[2, 2] { {7,8 } ,{9,10 } };


            //Accessing element of different type Array Members
            Accessing_element_of_different_type_Array_Members(Num,mulArr);

            //Encapsulating Attribute & Class & Object Creation
            Encapsulating_Attribute();

            //Structure type array
            //Structure_type_array();

            //Type of Constructor & Constructor overloading
            Type_of_Constructor();

            //Arrays of Objects
            Arrays_of_Objects();


            //Overloading Methods 
            Methods_Overloading("This is value 1 for overloading method");
            Methods_Overloading("This is value 1 for overloading method","this is value 2 for overloading method");

            //Understanding System String class and its various operations
            Understanding_System_String_class_and_its_various_operations();

            //Define Property and their Types
            Define_Property_and_their_Types();

        }

        internal static void Accessing_element_of_different_type_Array_Members(int[] num, int[,] MultArr)
        {
            Console.WriteLine("*----------------Accessing element of different type Array Members--------------*");

            Console.WriteLine("---------Manual Accesing---------");
            Console.WriteLine("Number 1: " + num[0] + "Number 2: "+ num[1] );

            Console.WriteLine("------Accesing with foreach-------");

            foreach (var member in num)
            {
                Console.WriteLine("Data: "+member);
            }

            Console.WriteLine("--------Accesing with for---------");
            for(int x = 0; x <= num.Length - 1; x++)
            {
                Console.WriteLine("Data: " + x);
            }


            Console.WriteLine("--------Array Multidimensional---------");
            for (int x = 0; x <= MultArr.GetLength(0)-1; x++)
            {
                for (int y = 0; y <= MultArr.GetLength(1)-1; y++)
                {
                    Console.WriteLine("Data: " + MultArr[x,y]);
                }                
            }

        }

        internal static void Encapsulating_Attribute()
        {

            Console.WriteLine("\n*----------------Encapsulating Attribute--------------*");

            Encap_ex en = new Encap_ex();

            en.SetName("Kevin");
            en.SetAge(12);
            en.SetDescription("This is an Encaptulating example");

            Console.WriteLine("Name: " +en.GetName()+"\tAge: "+en.GetAge()+"\tDescription: "+en.GetDescription());
            Console.WriteLine(en);

        }

        internal static void Structure_type_array()
        {

            Console.WriteLine("\n*----------------Structure type array--------------*");

            Person[] people = new Person[2];

            for (int x=0;x<=1;x++)
            {
                Console.WriteLine("Please entry the name"+x+": ");
                people[x].Name = Console.ReadLine();

                Console.WriteLine("Please entry the Age"+x+": ");
                people[x].Age = int.Parse(Console.ReadLine());

                Console.WriteLine("Please entry the Salary"+x+": ");
                people[x].Salary = decimal.Parse(Console.ReadLine());

            }
            for (int x = 0; x <= people.Length-1; x++)
            {
                Console.WriteLine("Name: " + people[x].Name + "\tAge: " + people[x].Age + "\tSalary: " + people[x].Salary);

            }

        }

        internal static void Type_of_Constructor()
        {
            Console.WriteLine("\n*----------------Type of Constructor--------------*");

            Contruc con = new Contruc();//empty construct
            Contruc con1 = new Contruc("Constructor whit one param");
            Contruc con2 = new Contruc("Constructor overloading value 1", "Constructor overloading value 2");//Constructor overloading

        }

        internal static void Arrays_of_Objects()
        {
            Console.WriteLine("\n*----------------Arrays of Objects--------------*");

            Encap_ex[] ObjArray = new Encap_ex[2];

            for (int x=0;x<=ObjArray.Length-1;x++)
            {
                ObjArray[x] = new Encap_ex();

                ObjArray[x].SetName("Kevin: "+x);
                ObjArray[x].SetAge(x);
                ObjArray[x].SetDescription("Description: " +x);
            }

            foreach (var ob in ObjArray)
            {
                Console.WriteLine("Name: " + ob.GetName() + " Age: " + ob.GetAge() + " Description: " + ob.GetDescription());
            }


        }

        internal static void Methods_Overloading(string str1)
        {
            Console.WriteLine("\n*----------------Methos Overloading--------------*");

            Console.WriteLine(str1);
        }

        internal static void Methods_Overloading(string str1, string str2)
        {        
            Console.WriteLine("\n"+str1 +"\n"+str2);
        }

        internal static void Understanding_System_String_class_and_its_various_operations()
        {
            Console.WriteLine("\n*-------Understanding System String class and its various operations-------*");
            
            Console.WriteLine("--------------Concat-------------");
            Console.WriteLine(String.Concat("This is value 1 ","this is value 2 ",132));
            
            Console.WriteLine("------UperCase and Low Case------");
            Console.WriteLine("uppercase".ToUpper()+" "+"LOWCASE".ToLower());

            Console.WriteLine("--------------Replace-------------");
            Console.WriteLine("this is a test".Replace(" ",""));
            
            Console.WriteLine("-------------Substring------------");
            Console.WriteLine("this is a test".Substring(3,7));
      
            Console.WriteLine("---------------Trim---------------");
            Console.WriteLine("this is a test".Trim());

            Console.WriteLine("-------------Substring------------");
            Console.WriteLine("this is a test".Contains("test"));// Contains is to know if there is an world on string

            Console.WriteLine("-------------startsWith------------");
            Console.WriteLine("this is a test".StartsWith("this")); //this is to know if the string begins with the especific word

            Console.WriteLine("-----------isNull or Empty----------");
            string str = null;
            Console.WriteLine(string.IsNullOrEmpty(str));

            Console.WriteLine("------------get position------------");
            Console.WriteLine("this is a test".IndexOf("test"));

            Console.WriteLine("------------Length------------");
            Console.WriteLine("this is a test".Length);

        }

        internal static void Define_Property_and_their_Types()
        {
            Console.WriteLine("\n*------------Define Property and their Types---------------*");

            Encap_ex en = new Encap_ex();

            en.SalaryFullProperty = 1212;

            Console.WriteLine(en.SalaryFullProperty);

        }







        internal static void Topic1()
        {
            //Implicity Typed Local Variables
            Implicity_Typed_Local_Variables();

            //Conditional Syntax
            Conditional_Syntax("Kevin");

            //C# Operators
            Language_Operators();

            //Looping Syntax
            Looping_Syntax();

            //Structure
            Structure_syntaxis();
        }

        internal static void Implicity_Typed_Local_Variables()
        {
            var impliVarInt = 12;
            var impliVarstring = "Kevin";
            Console.WriteLine("\n*---------Implicity Typed Local Variables-------*");
            Console.WriteLine("Hi my name is: " + impliVarstring + " im " + impliVarInt + " years old");

        }

        internal static void Conditional_Syntax(string Name)
        {

            Console.WriteLine("\n*----------------Conditional syntax--------------*");

            Console.WriteLine("*---------basic syntax-------*");
            if (Name == "Kevin")
            {
                Console.WriteLine("your name is "+ Name);
            }
            else
            {
                Console.WriteLine("your name is not kevin");
            }

            Console.WriteLine("*---------? symbol syntax-------*");
            var result = Name == "Kevin" ? "your name is " + Name : "your name is not kevin";
            Console.WriteLine(result);

        }

        internal static void Language_Operators()
        {

            Console.WriteLine("\n*-----------------Language Operator----------------*");
            Console.WriteLine("-------Arithmetic (+ - * / % )-------");
            int num1 = 20,num2 = 10;

            Console.WriteLine("Adition Operator Result:" + (num1 + num2));
            Console.WriteLine("Subtraction Operator Result:" + (num1 - num2));
            Console.WriteLine("Multiplication Operator Result:" + (num1 * num2));
            Console.WriteLine("Division Operator Result:" + (num1 / num2));
            Console.WriteLine("Modulus Operator Result:" + (num1 % num2));         

            Console.WriteLine("------------Comparison--------------");
            Console.WriteLine("Equals to Operator Result:" + (num1 == num2));
            Console.WriteLine("Not Equals to Operator Result:" + (num1 != num2));
            Console.WriteLine("Greater than to Operator Result:" + (num1 > num2));
            Console.WriteLine("Less than to Operator Result:" + (num1 < num2));
            Console.WriteLine("Greater than or equal to Operator Result:" + (num1 >= num2));
            Console.WriteLine("Less than or equal to Operator Result:" + (num1 <= num2));


            Console.WriteLine("--------------Logical--------------");
            Console.WriteLine("Logical and Operator Result:" + ((num1 == num2) && (num1 >= num2)));
            Console.WriteLine("Logical or to Operator Result:" + ((num1 == num2) || (num1 >= num2)));
            Console.WriteLine("Logical not to Operator Result:" + !(num1 == num2));
        }

        internal static void Looping_Syntax() {

            Console.WriteLine("\n*-----------------Loopíng Syntax---------------------*");

            int whilev=0;
            int[] forEac = new int[3] { 1,2,3} ;


            Console.WriteLine("----------For--------");
            for (int x=0;x<=3;x++)
            {
                Console.WriteLine("Basisc looping for syntax: "+x);
            }
            Console.WriteLine("----------while--------");
            while (whilev <= 3)
            {
                Console.WriteLine("Basisc looping while syntax: " + whilev);
                whilev += 1;
            }
            Console.WriteLine("----------for each--------");
            foreach (int f in forEac)
            {
                Console.WriteLine("Basisc looping foreach syntax: " + f);
            }

        }

        internal static void Structure_syntaxis()
        {

            Console.WriteLine("\n*-----------------Structure--------------------*");

            Person per;
            per.Name = "Kevin";
            per.Salary = 1200;
            per.Age = 26;

            Console.WriteLine("Structure information Name: "+per.Name+"\t Age: "+per.Age+"\t Salary: "+per.Salary );

        }

    }
}
