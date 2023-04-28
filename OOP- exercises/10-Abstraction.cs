namespace OOP__exercises
{
    // Abstract classes
    internal abstract class Person3
    {
        public int age;
        public string name;
        public int id;
        public string favouriteGame;

        // abstract properties
        public abstract string FavorateGame { get; set; }

        // Abstact methods

        public abstract void PrintDetails();

        public abstract int CalculateSum( int bumber1 , int number2 );
    }

    internal class Student5 : Person3
    {
        public int grade;
        public string rollno;
        public string favorateGame;

        public override string FavorateGame
        {
            set
            {
                this.favouriteGame = value;
            }
            get
            {
                return this.favouriteGame;
            }
        }

        public Student5( int age , int id , string name , string rollno , int grade )
        {
            this.age = age;
            this.name = name;

            this.id = id;
            this.grade = grade;
            this.rollno = rollno;
        }

        public override int CalculateSum( int number1 , int number2 )
        {
            return number2 + number1;
        }

        public override void PrintDetails()
        {
            Console.WriteLine($"Id :  {id} Name :" +
                $" {name} Age : {age} Roll No : {rollno} Grade: {grade}");
        }

        public void PrintSum()
        {
            Console.WriteLine("The sum is : {0}" , this.CalculateSum(12 , 45));
        }
    }

    // Example 2
    internal abstract class Animal1
    {
        public abstract void Sleep();

        public abstract void Eat();

        // abstract poperties
        public abstract string kingDom { get; set; }
    }

    internal class Lion : Animal1
    {
        public string kingdom;

        public override void Eat()
        {
            Console.WriteLine("The Lion is Eating Meet");
        }

        public override void Sleep()
        {
            Console.WriteLine("The Lion is Sleeping");
        }

        public override string kingDom
        {
            set
            {
                this.kingdom = value;
            }
            get
            {
                return this.kingdom;
            }
        }
    }

    internal class Girafe : Animal1
    {
        public override void Eat()
        {
            Console.WriteLine("The Giraffe is Eating Meet");
        }

        public override void Sleep()
        {
            Console.WriteLine("The Giraffe is Sleeping");
        }

        public override string kingDom
        {
            set
            {
                this.kingDom = value;
            }
            get
            {
                return this.kingDom;
            }
        }
    }

    public class _10_Abstraction
    {
        public static void Main()
        {
            Student5 student = new Student5(21 , 1 , "Ali Hassan" , "5063" , 78);
            student.PrintSum( );
            student.FavorateGame = "Cricket";
            Console.WriteLine(student.favouriteGame);
            Lion lion = new Lion( );

            lion.Sleep( );
            lion.kingDom = "Dandrous";
            Console.WriteLine(lion.kingDom);
        }
    }
}