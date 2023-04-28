using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace OOP__exercises
{
    public  class SealedClass
    {
        private int id, age;
        private string name;
        public SealedClass(int id, string name )
        {
            this.id = id;
            this.name = name;

            
        }
        public void PrintData()
        {
            Console.WriteLine($"Id: {id}  Name: {name}" );
        }
    }
    // Sealed methods 
    class A1
    {
        public virtual int  CalculateSum(int number1, int number2)
        {
            Console.WriteLine("printer printing....\n");
            return 0;
        }



    }
    class B2:A2
    {
        public sealed override int CalculateSum(int number1, int number2)
        {
            return number1+ number2;
        }
    }
    class C2:B2
    {
        // This is error due to its has asealed class
        //public override int CalculateSum( int number1 , int number2 )
        //{
        //    return number1 + number2;
        //}

    }

    class SealedMain
    {
        private static void Main()
        {
            SealedClass sealedClass = new SealedClass(12 , "Ali Hassan");
            sealedClass.PrintData( );


        }
    }
}
