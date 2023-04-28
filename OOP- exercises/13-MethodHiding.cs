using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP__exercises
{
    class Base
    {
        public void Show()
        {
            Console.WriteLine("This is the Base class methods");
        }

    }
    class Parent1:Base
    {
        public new  void Show()
        {
           // base.Show( );

            Console.WriteLine("This is the Child  class methods");
        }

    }
    public class _13_MethodHiding
    {
        private static void Main()
        {
            Parent1 parent1 = new Parent1();
            parent1.Show( );
            // we also call the parent class method by casting
            ((Base)parent1).Show( );

            
        }
    }
}
