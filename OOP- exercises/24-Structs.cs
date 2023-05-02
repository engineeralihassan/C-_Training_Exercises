namespace OOP__exercises
{
    public struct Student1
    {
        int id;
        int zipcode;
        double salary;
        // all the members of the struct has to be initialized in this way  
        public Student1(int id, int zipcode, double salary)
        {
            this.id = id;
            this.zipcode = zipcode;
            this.salary = salary;
        }
        // all the members of the struct has to be initialized either in this way  
        public Student1(int id, int zipcode)
        {
            this.id = id;
            this.zipcode = zipcode;
            this.salary = 3400.00;
        }
        // if you left any member of a struct uninitialzed it will give error  
        // code below will give error because the zipcode and salary field is left uninitialzed  
        //public Student(int id)  
        //{  
        // this.id = id;  
        //}  
        // struct can also have copy constructor but have to be fully initialzed  
        public Student1(Student1 x)
        {
            this.id = x.id;
            this.zipcode = x.zipcode;
            this.salary = x.salary;
        }
        public void DisplayValues()
        {
            Console.WriteLine("ID: " + this.id.ToString());
            Console.WriteLine("Zipcode : " + this.zipcode.ToString());
            Console.WriteLine("Salary : " + this.salary.ToString());
        }
    }
    public class Structs
    {
        static void Main(string[] args)
        {
            Student1 stu = new Student1(12, 201301, 4560.00);
            Student1 stu1 = new Student1(stu);
            stu.DisplayValues();
            Console.WriteLine("Copy constructor values");
            stu1.DisplayValues();
            Console.ReadLine();
        }
    }
}
