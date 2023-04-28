using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP__exercises
{
    class Base1
    {
        public virtual void Show()
        {
            Console.WriteLine("This is the Base class methods");
        }

    }
    class Parent2 : Base1
    {
        public override void Show()
        {
          

            Console.WriteLine("This is the Child  class methods");
        }

    }
    public class _14_MethodOverriding
    {
        private static void Main()
        {
            Parent2 parent2 = new Parent2( );
            parent2.Show( );
            Base1 base1 = new Parent2( );
            base1.Show( );




        }
    }
}
