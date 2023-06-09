﻿namespace OOP__exercises
{
    // static and instance members
    internal class Calculator
    {
        public int age;
        public static int fees;
        public static string name;

        public static int GetSum( int number1 , int number2 )
        {
            return number1 + number2;
        }

        public static int GetSubtract( int number1 , int number2 )
        {
            return number1 - number2;
        }
    }

    internal class Person1
    {
        public int age;
        public string name;
        public string gender;

        public Person1( string name , int age , string gender )
        {
            this.name = name;
            this.age = age;
            this.gender = gender;
        }
    }

    internal class Shap
    {
        public int area;

        public void CalculateArea( int width , int height )
        {
            this.area = height * width;
        }

        public void ShowArea()
        {
            Console.WriteLine(this.area);
        }
    }

    internal class Employee
    {
        public string name;
        public int id;
        public static int nextId = 1;
        public static int totalAcount = 0;

        public Employee( string name , int id )
        {
            this.name = name;
            this.id = id;
        }

        public void GetDetails()
        {
            Console.WriteLine($" Name : {name} Id {id}");
        }
    }

    internal class MeezanBank
    {
        public int balance;
        public static int intrestRate;
        public static int accountCount;

        public MeezanBank( int balance )
        {
            this.balance = balance;
        }

        public int Calculateintrest()
        {
            intrestRate = this.balance / 10;
            return intrestRate;
        }

        public void ShowBalance()
        {
            Console.WriteLine($"The balance is : {balance + intrestRate}");
        }
    }

    // static constructors
    internal class Logger
    {
        public static string logFile;

        static Logger()
        {
            logFile = DateTime.Now.ToString("yyyyMMdd_HHmmss");
        }

        public static void LogMessage( string message )
        {
            Console.WriteLine(logFile + message);
        }
    }

    public class Singleton
    {
        private Singleton()
        {
            Console.WriteLine("The constructor is running");
        }
    }

    internal class Database
    {
        private static string name;

        static Database()
        {
            name = "school_db";
            Console.WriteLine("The data base is created");
        }

        public static void ApplyQuiry( string query )
        {
            Console.WriteLine($"{query} is apply on the {name}");
        }
    }

    // copy constructor
    internal class Person2
    {
        public string name;
        public int age;

        public Person2( string name , int age )
        {
            this.name = name;
            this.age = age;
        }

        public Person2( Person2 obj )
        {
            this.name = obj.name;
            this.age = obj.age;
        }

        public void PrintDetails()
        {
            Console.WriteLine($"Name : {name} Age: {age} ");
        }
    }

    internal class Vehicle1
    {
        public string make;
        public int model;

        public Vehicle1( string make , int model )
        {
            this.model = model;
            this.make = make;
        }

        public Vehicle1( Vehicle1 e )
        {
            this.model = e.model;
            this.make = e.make;
        }

        public void GetDetails()
        {
            Console.WriteLine($"Model {model} Maker : {make} ");
        }
    }

    public class _03_staticMembers
    {
        private static void Main()
        {
            Console.WriteLine(Calculator.GetSubtract(23 , 12));
            Console.WriteLine(Calculator.GetSum(23 , 12));
            Calculator calculator = new Calculator( );

            // instance members
            Shap shap = new Shap( );
            shap.CalculateArea(23 , 45);
            shap.ShowArea( );
            Employee employ = new Employee("Ali Hassan" , 1);
            employ.GetDetails( );
            Console.WriteLine(Employee.nextId);
            Employee employ1 = new Employee("Babar shehzad" , 2);
            employ1.GetDetails( );
            Employee.nextId = Employee.nextId + 1;
            Console.WriteLine(Employee.nextId);
            Employee employ2 = new Employee("Asim munir" , 3);
            employ2.GetDetails( );
            Employee.nextId = Employee.nextId + 1;
            Console.WriteLine(Employee.nextId);
            MeezanBank meezanBank = new MeezanBank(34567);
            meezanBank.Calculateintrest( );
            MeezanBank meezanBank1 = new MeezanBank(34567);
            meezanBank1.Calculateintrest( );
            MeezanBank meezanBank2 = new MeezanBank(34567);
            meezanBank1.Calculateintrest( );
            Console.WriteLine(MeezanBank.intrestRate);
            Console.WriteLine(MeezanBank.accountCount);
            // static constructors
            Logger.LogMessage("This is message string");
            Database.ApplyQuiry("Select *from my_tbl");
            // copy constructors
            Person2 person2 = new Person2("Ali Hassan" , 21);
            person2.PrintDetails( );
            Person2 person3 = new Person2(person2);
            person3.PrintDetails( );
            Vehicle1 vehicle1 = new Vehicle1("Suzuki international" , 2022);
            Vehicle1 vehicle2 = new Vehicle1(vehicle1);
            // privatte constructors
            //  Singleton singleton = new Singleton( );
        }
    }
}