namespace OOP__exercises
{
    public class BaseClass
    {
        public string name;
        public int age;
        public int id;
        public int sum;

        public BaseClass()
        {
            Console.WriteLine("This is the base clas constructors ");
        }

        public BaseClass( string name , int id )
        {
            this.name
                = name;
            this.id = id;
        }

        public BaseClass( int sum )
        {
            this.sum = sum;
        }
    }

    public class DeriveClass : BaseClass
    {
        public int salary;

        public DeriveClass()
        {
            Console.WriteLine("this is the Derive class constructors");
        }

        public DeriveClass( int salry , int age , string name1 , int id ) : base(name1 , id)
        {
            this.salary = salry;
            this.age = age;
        }

        public void PrintDetails()
        {
            Console.WriteLine($"{age} {salary} {name}");
        }
    }

    internal class ChildClass2 : DeriveClass
    {
        public ChildClass2()
        {
            Console.WriteLine("this is the third class constructors");
        }

        public ChildClass2( int sum )
        {
            Console.WriteLine("this is the third class constructors");
        }
    }

    // Constructors in Multilevel inheritance
    public class A
    {
        public int ValueA;

        public A( int valueA )
        {
            ValueA = valueA;
        }
    }

    public class B : A
    {
        public int ValueB;

        public B( int valueA , int valueB ) : base(valueA)
        {
            ValueB = valueB;
        }
    }

    public class C : B
    {
        public C( int valueA , int valueB , int valueC ) : base(valueA , valueB)
        {
            // Initialize the value of class A in class C constructor
            ValueA = valueA;

            // Initialize the value of class C
            ValueC = valueC;
        }

        public int ValueC { get; set; }
    }

    public class _07ConstructorsINheritance
    {
        private static void Main()
        {
            DeriveClass deriveClass1 = new DeriveClass( );
            DeriveClass deriveClass = new DeriveClass(12 , 45 , "Ali hassan" , 45);
            deriveClass.PrintDetails( );
            ChildClass2 childClass2 = new ChildClass2( );
            C c = new C(12 , 34 , 56);
        }
    }
}