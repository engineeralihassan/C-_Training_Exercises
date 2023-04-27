using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP__exercises
{
    public class _09_ExplicitInterfaces
    {
        interface Interface1
        {
            void show();

            void PrintAge( int age );
        }
        interface Interface2
        {
            void show();
        }
        interface Interface3
        {
            void show();
            void PrintAge( int age );
        }
      public class Parent1: Interface1,Interface2, Interface3
        {
             void Interface1.show()
            {
                Console.WriteLine("This is interface 1 methods");
            }
            
           public   void PrintAge(int age )
            {
                Console.WriteLine("The age is : {0} ",age);
            }
            void Interface2.show()
            {
                Console.WriteLine("This is interface 2 methods");
            }
            void Interface3.show()
            {
                Console.WriteLine("This is interface 3 methods");
            }
           public  void show()
            {
                Console.WriteLine("This is the class method");
            } 
        }
        private static void Main()
        {
          Interface3 parent1 = new Parent1();
            parent1.show( );
            parent1.show( );
            Parent1 parent11 = new Parent1();
            parent11.show( );
            parent11.PrintAge(12);
            parent1.PrintAge(15);
           

        }
    }
}
