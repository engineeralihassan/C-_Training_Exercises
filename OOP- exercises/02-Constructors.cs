namespace OOP__exercises
{
    internal class Person
    {
        private string name;
        private string gender;
        private int age;

        public Person( string name , int age , string gender )
        {
            this.name = name;
            this.gender = gender;
            this.age = age;
        }

        public void GetDetails()
        {
            Console.WriteLine($" {name} {age}  {gender}");
        }
    }

    internal class Area
    {
        private int lenght;
        private int width;
        private int area;

        public Area( int lenght , int width )
        {
            this.lenght = lenght;
            this.width = width;
        }

        public void GetArea()
        {
            this.area = this.width + this.lenght;
            Console.WriteLine("The area is : {0}" , this.area);
        }
    }

    internal class Bank1
    {
        private int acountNumber;
        private int balance;

        public Bank1()
        {
        }

        public Bank1( int acountNumber1 , int balance )
        {
            this.acountNumber = acountNumber1;
            this.balance = balance;
        }

        public void WithDraw( int withdrawal )
        {
            this.balance = balance - withdrawal;
            Console.WriteLine(this.balance);
        }
    }

    public class Vehicle
    {
        public string make;
        public string model;

        public Vehicle( string make , string model )
        {
            this.make = make;
            this.model = model;
        }
    }

    internal class Car : Vehicle
    {
        private string brand;

        public Car( string make , string model , string brand ) : base(make , model)
        {
            this.brand = brand;
        }

        public void GetInformation()
        {
            Console.WriteLine($"Model {model} Make: {make} Brand : {brand}");
        }
    }

    public class _02_Constructors
    {
        private static void Main()
        {
            Console.WriteLine("Wellcome to constructors");
            Person person = new Person("Ali Hassan" , 21 , "Male");
            person.GetDetails( );
            Area area = new Area(12 , 34);
            area.GetArea( );
            Bank1 bank = new Bank1( );
            Bank1 bank1 = new Bank1(12345678 , 34000);
            //bank.WithDraw(23000);
            bank1.WithDraw(22000);
            Car car = new Car("By tata farari" , "BRV-3" , "2022");
            car.GetInformation( );
        }
    }
}