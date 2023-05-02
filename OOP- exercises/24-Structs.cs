namespace OOP__exercises
{
    public struct Student1
    {
        private int id;
        private int zipcode;
        private double salary;

        // all the members of the struct has to be initialized in this way
        public Student1(int id, int zipcode, double salary)
        {
            this.id = id;
            this.zipcode = zipcode;
            this.salary = salary;
        }

        public Student1(int id, int zipcode)
        {
            this.id = id;
            this.zipcode = zipcode;
            this.salary = 3400.00;
        }

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
        private static void Main(string[] args)
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