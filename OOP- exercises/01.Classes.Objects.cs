namespace OOP__exercises
{
    internal class ClassesObjects
    {
        public int width;
        public int height;

        public ClassesObjects( int width , int height )
        {
            this.width = width;
            this.height = height;
        }

        public int GetArea()
        {
            return width * height;
        }

        public void GetDatails( string name , int age , string occupation )
        {
            Console.WriteLine($"Name : {name} Age: {age} Occupation {occupation}");
        }
    }

    internal class Students
    {
        public string name;
        public int age;
        public string occupation;

        public Students( string name , int age , string occupation )
        {
            this.name = name;
            this.age = age;
            this.occupation = occupation;
        }

        public void GetDatails()
        {
            Console.WriteLine($"Name : {name} Age: {age} Occupation {occupation}");
        }
    }

    internal class Bank
    {
        public int balance { get; set; }
        public int acountNumber { get; set; }

        public int Deposit( int depositedMoney )
        {
            balance = balance + depositedMoney;
            return balance;
        }

        public int Withdraw( int withdrawal )
        {
            balance = balance - withdrawal;
            return balance;
        }

        public void GetBalance()
        {
            Console.WriteLine(balance);
        }
    }

    internal class Employees
    {
        public string name { get; set; }
        public int salary { get; set; }
        public DateTime hireDate { get; set; }

        public void Details()
        {
            DateTime currTime = DateTime.Now;
            int service = currTime.Year - hireDate.Year;
            Console.WriteLine($"Name : {name} salary: {salary} Service {service}");
        }
    }

    internal class Program1
    {
        private static void Main()
        {
            ClassesObjects classObject = new ClassesObjects(44 , 67);
            Console.WriteLine("The Are is : " + " " + classObject.GetArea( ));
            // exercise 2
            Students [] students = new Students []
            {
                new Students("Ali Hassan",21,"Teacher"),
                 new Students("Ali Hassan1",21,"Teacher"),
                  new Students("Ali Hassan2",21,"Teacher"),
                   new Students("Ali Hassan3",21,"Teacher"),
                    new Students("Ali Hassan4",21,"Teacher"),
                     new Students("Ali Hassan5",21,"Teacher"),
                      new Students("Ali Hassan6",21,"Teacher"),
                       new Students("Ali Hassan7",21,"Teacher"),
                        new Students("Ali Hassan8",21,"Teacher"),
            };

            foreach ( Students item in students )
            {
                item.GetDatails( );
            }

            Bank bank = new Bank( );
            bank.balance = 45000;
            bank.acountNumber = 123456789;
            Console.WriteLine(bank.Deposit(23000));
            Console.WriteLine(bank.Withdraw(5000));
            bank.GetBalance( );
            Employees [] employees = new Employees []
            {
                new Employees { name="Ali Hassan"
                ,salary=25000,hireDate=new DateTime(2002,12,13) },
                          new Employees { name="Ali Hassan1",salary=25000,hireDate=new DateTime(2012,12,13) },
                                    new Employees { name="Ali Hassan2",salary=25000,hireDate=new DateTime(2013,12,13) },
                                              new Employees { name="Ali Hassan3",salary=25000,hireDate=new DateTime(2017,12,13) },
                                                        new Employees { name="Ali Hassan4",salary=25000,hireDate=new DateTime(1234,12,13) },
                                                                  new Employees { name="Ali Hassan5",salary=25000,hireDate=new DateTime(2002,12,13) },
                                                                            new Employees { name="Ali Hassan6",salary=25000,hireDate=new DateTime(2006,12,13) },
                                                                                      new Employees { name="Ali Hassan7",salary=25000,hireDate=new DateTime(2007,12,13) },
                                                                                                new Employees { name="Ali Hassan8",salary=25000,hireDate=new DateTime(2000,12,13) },
                                                                                                          new Employees { name="Ali Hassan9",salary=25000,hireDate=new DateTime(2001,12,13) },
            };
            foreach ( var item in employees )
            {
                item.Details( );
            }
        }
    }
}