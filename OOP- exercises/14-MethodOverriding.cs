namespace OOP__exercises
{
    internal class Base1
    {
        public virtual void Show()
        {
            Console.WriteLine("This is the Base class methods");
        }
    }

    internal class Parent2 : Base1
    {
        public override void Show()
        {
            // call the base class method
            // base.Show( );

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
            Base1 base2 = new Base1( );
            base2.Show( );
        }
    }
}