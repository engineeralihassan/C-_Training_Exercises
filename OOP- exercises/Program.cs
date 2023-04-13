namespace OOP__exercises
{
    internal class Student
    {
        public int id;
        public string name;
        public int age;
        public string standard;
        public string address;
        public int rollNo;

        public Student( int id , string name , int age , string standard , string address , int rollNo )
        {
            this.id = id;
            this.name = name;
            this.age = age;
            this.standard = standard;
            this.address = address;
            this.rollNo = rollNo;
        }

        public void GetDetails()
        {
            Console.WriteLine("id:{0} name: {1} age: {2}" +
                " class: {3} rollNo : {4} address: {5} " , this.id , this.name , this.age , this.standard , this.rollNo , this.address);
        }
    }

    public class Program
    {
        private static void Main( string [] args )
        {
            Console.WriteLine("List of Students of Educators school");
            Student student = new Student(1 , "Ali Hassan" , 21 , "BSSE-A" , "Chack no 11/1L" , 5063);
            List<Student> people = new List<Student>( );
            people.Add(student);
            Student student2 = new Student(2 , "Ali Imran" , 22 , "BSSE-A" , "Chack no 11/1L" , 5061);
            Student student3 = new Student(3 , "Ahsan mughal" , 22 , "BSSE-A" , "Chack no 11/1L" , 5064);
            Student student4 = new Student(4 , "Amjad sabri" , 23 , "BSSE-A" , "Chack no 11/1L" , 5065);
            Student student5 = new Student(5 , "AD Malik" , 24 , "BSSE-A" , "Chack no 11/1L" , 5066);
            Student student6 = new Student(6 , "Asim Hameed" , 18 , "BSSE-A" , "Chack no 11/1L" , 5067);
            Student student7 = new Student(7 , "Humayun sheikh " , 20 , "BSSE-A" , "Chack no 11/1L" , 5069);
            Student student8 = new Student(8 , "Numan  ali" , 16 , "BSSE-A" , "Chack no 11/1L" , 50670);
            Student student9 = new Student(9 , "Babar shehzad" , 45 , "BSSE-A" , "Chack no 11/1L" , 5071);
            Student student10 = new Student(10 , "Abubakar sadique" , 67 , "BSSE-A" , "Chack no 11/1L" , 5072);
            people.Add(student2);
            people.Add(student3);
            people.Add(student4);
            people.Add(student5);
            people.Add(student6);
            people.Add(student7);
            people.Add(student8);
            people.Add(student9);
            people.Add(student10);
            foreach ( Student person in people )
            {
                Console.WriteLine($"id : {person.id}  Name: {person.name}  age:{person.age}  standard : {person.standard} Address: {person.address}  RollNo:{person.rollNo}");
            }
        }
    }
}