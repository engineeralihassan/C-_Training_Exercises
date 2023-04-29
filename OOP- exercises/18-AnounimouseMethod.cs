using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP__exercises
{
    // Delegate
   
    public class _18_AnounimouseMethod
    {
        public static void DelegateMethod( MyDelegate method )
        {
            int number = 12;
            method(number);
        }
        public delegate int MyDelegate( int number );
        private static void Main()
        {
            string name = "Ali Hassan";
            Console.WriteLine("Wellcome to Anounimouse methods");
            MyDelegate myDelegate = delegate ( int number )
            {
                Console.WriteLine("My name is {0}",name);
                return number + 10;
            };
            Console.WriteLine( myDelegate( 12 ));

            DelegateMethod(delegate ( int number )
            {
                Console.WriteLine("The number from the delagate method is {0}" , number);
                return number;
            });
            
        }
    }
}
