namespace Extension_Methods
{
    class Student
    {
        public int age = 20;
        public string name = "Ali Hassan";

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public void Function1()
        {
            Console.WriteLine("this is the OldClass class method");
        }
        public void Function2()
        {
            Console.WriteLine("this is the OldClass class method2");
        }
        public void Function3()
        {
            Console.WriteLine("this is the OldClass class method3");
        }
    }
    class Employee
    {

        public int age = 23;
        public string name = "Asim muneer";
        public void Function1()
        {
            Console.WriteLine("this is the OldClass class method");
        }
        public void Function2()
        {
            Console.WriteLine("this is the OldClass class method2");
        }
        public void Function3()
        {
            Console.WriteLine("this is the OldClass class method3");
        }

    }
    public class Program
    {
        static void Main( string [] args )
        {
            Console.WriteLine("Hello, World!");
            Student studentClassObject = new Student( );
            Console.WriteLine(studentClassObject.GetFullName( ));
            Console.WriteLine(studentClassObject.GetAge( ));
            Employee employeeClassObject = new Employee( );
            Console.WriteLine(employeeClassObject.GetFullName( ));
          // Date of birth methods 
            studentClassObject.DateOfBirth = new DateTime(1990, 10, 12);
            Console.WriteLine("age is "+ studentClassObject.GetAge());
            // Extensions Method for string 
            string message = "This is the real message";
            string modyfiedMeassage = message.modify( );
            Console.WriteLine( modyfiedMeassage);
            int number = 11;
            if ( number.IsEven( ) )
            {
                Console.WriteLine("The number is even");
            }
            else
            {
                Console.WriteLine("The number is ODD");
            }

        }
    }
}