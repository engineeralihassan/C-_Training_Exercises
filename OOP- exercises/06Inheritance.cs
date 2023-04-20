namespace OOP__exercises
{
    internal class Employe
    {
        public int EmployId;
        public string name;
        public int age;
        public string designation;
    }

    internal class VisitingEmploy : Employe
    {
        public int salary;
        public int workHours;

        public void SetDetails( int id , string name , int age , string
            designation , int salary , int workHours )
        {
            this.EmployId = id;
            this.name = name;
            this.age = age;
            this.designation = designation;
            this.salary = salary;
            this.workHours = workHours;
        }

        public void PrintDetails()
        {
            Console.WriteLine($"EmployId  {EmployId}  Name : {name} Age:{age}  EmployType : Visiting Designation :{designation} salary: {salary}  ");
        }

        public void PrintEmployees( VisitingEmploy [] Employees )
        {
            foreach ( VisitingEmploy employ in Employees )
            {
                Console.WriteLine($"EmployId  {employ.EmployId}  Name : {employ.name} Age:{employ.age}  EmployType : Visiting Designation :{employ.designation} salary: {employ.salary}  ");
            }
        }
    }

    //# Inheritance in the C# examples
    // Example N0 1
    public class Animal
    {
        public string animalType { get; set; }
        public void CheckKingdom()
        {
            Console.WriteLine("The  is belongs to animal Kingdom");
        }
    }

    public class Cat : Animal
    {
        public string animalType { get; set; }

        public Boolean IsPet()
        {
            return true;
        }
    }
    class Dog :Animal
    {
        public Boolean IsPet()
        {
            return true;
        }

        public Boolean IsBull()
        {
            return false;
        }

    }
    // Example 2
    class Vehicl
    {
        public string company { get; set; }
        public int model { get; set; }

    }
    class LTV: Vehicl
    {
      public void PrintDetails()
        {
            Console.WriteLine($"This LTV is made by {company} and its model is {model}");
        }
    }
    class HTV : Vehicl
    {
        public void PrintDetails()
        {
            Console.WriteLine($"This HTV is made by {company} and its model is {model}");
        }
    }
    /// <summary>
    // Type of inheritance starts from here
    /// </summary>
    // single inheritance
    class Bank11
    {
        public string acountType;
        public int acountBalance;
        public string acountHolder;
    }
    class HabibBank :Bank11
    {
        public void SetDEtails(string customerName,string acountType, int balance)
        {
            this.acountHolder = customerName;
            this.acountType = acountType;
           this.acountBalance = balance ;
        }

        public void Withdraw(int withdraw)
        {
            acountBalance=acountBalance-withdraw;

           
        }
       public void  PrintDEtails()
        {
            Console.WriteLine($"Customer name {acountHolder} Acount-Type {acountType} Total Balance {acountBalance} ");
        }
    }

    public class _06Inheritance
    {
        private static void Main()
        {
            Console.WriteLine("Wellcome to Inheritance World");
            VisitingEmploy employ = new VisitingEmploy( );
            employ.SetDetails(1 , "Ali Hassan" , 21 , "Senior super visor" , 23000 , 8);
            employ.PrintDetails( );
            // Array of object
            VisitingEmploy [] employsArray = new VisitingEmploy []
            {
                    new VisitingEmploy{EmployId=1,name="Ali Hassan",age=21,designation="Senior super visor",salary=23000,workHours=8},
                    new VisitingEmploy{EmployId=2,name="Ali Hassan",age=21,designation="Senior super visor",salary=23000,workHours=8},

                    new VisitingEmploy{EmployId=3,name="Ali Hassan",age=21,designation="Senior super visor",salary=23000,workHours=8},
                    new VisitingEmploy{EmployId=4,name="Ali Hassan",age=21,designation="Senior super visor",salary=23000,workHours=8},
                    new VisitingEmploy{EmployId=5,name="Ali Hassan",age=21,designation="Senior super visor",salary=23000,workHours=8},
            };
            employ.PrintEmployees(employsArray);
            // Example 1 object
            Dog dog = new Dog();
            dog.animalType = "Dangrouse";
            dog.CheckKingdom( );
            Console.WriteLine(dog.IsPet( ));
            Console.WriteLine(dog.IsBull( ));
            // Example 2 object 
            LTV lTV = new LTV();
            lTV.company = "BMW";
            lTV.model = 2012;
            lTV.PrintDetails( );
            // single inheritance object
            HabibBank habibBank = new HabibBank();
            habibBank.SetDEtails("Ali Hassan" , "Deposit" , 23000);
            habibBank.Withdraw(4500);
            habibBank.PrintDEtails( );


            



        }
    }
}