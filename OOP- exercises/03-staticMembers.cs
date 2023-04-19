using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace OOP__exercises
{
    // static and instance members
    class Calculator
    {
        public int age;
        public static int fees;
        public static string name;

        public static int GetSum(int number1, int number2)
        {
            return number1+ number2;
        }
        public static int GetSubtract( int number1 , int number2 )
        {
            return number1 - number2;
        }
    }
   class Person1
    {
        public int age;
        public string name;
        public string gender;
        public Person1( string name, int age, string gender)
        {
            this.name = name;
            this.age = age;
            this.gender = gender;
        }

    } 
    class Shap
    {
        public int area;
         
        public void   CalculateArea(int width , int height)
        {
            this.area= height * width;
        } 
        public void ShowArea()
        {
            Console.WriteLine(this.area);
        }
    }
   class Employee
    {
        public string name;
        public int id;
       public  static int nextId=1;
            public static int totalAcount=0;
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
    class MeezanBank
    {
        public int balance;
        public static int intrestRate;
        public static int accountCount;
        public MeezanBank(int balance )
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
            Console.WriteLine($"The balance is : {balance+intrestRate}");
        }
    }
   // static constructors
    class Logger
    {
        public static string logFile;
        static Logger()
        {
            logFile =  DateTime.Now.ToString("yyyyMMdd_HHmmss");
        }
      public  static void LogMessage(string message )
        {
            Console.WriteLine(logFile+ message);
        } 
        
      
    }
    class Database
    {
        static string name;
        static Database()
        {
            name = "school_db";
            Console.WriteLine("The data base is created");
        }
        public static void ApplyQuiry(string query )
        {
            Console.WriteLine($"{query} is apply on the {name}");
        } 
    }
      
      // copy constructor
      class Person2
    {
        public string name;
        public int age ;
        public Person2( string name , int age)
        {
            this.name= name;
            this.age= age;

        }
       public Person2(Person2 obj )
        {
            this.name = obj.name;
            this.age = obj.age;
        }
        public void PrintDetails()
        {
            Console.WriteLine($"Name : {name} Age: {age} ");
        }
    }

    public class _03_staticMembers
    {
        static void Main()
        {
            Console.WriteLine(Calculator.GetSubtract(23,12));
            Console.WriteLine(Calculator.GetSum(23 , 12));
            Calculator calculator = new Calculator();
            // instance members
            Shap shap = new Shap();
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
            MeezanBank meezanBank = new MeezanBank( 34567);
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







        }
    }
}
