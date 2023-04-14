using System.Text;

namespace OOP__exercises
{
    enum Level
    {
        Low,
        Medium,
        High
    }

    public class Fundamentals
    {
        private const int MAX_VALUE = 100;
        private readonly string CONNECTION_STRING;

        private Fundamentals()
        {
            this.CONNECTION_STRING = "My name is Ali Hassan i learn c# programing language";
            Console.WriteLine(MAX_VALUE);
        }

        public void GetSquare( ref int number )
        {
            number = number * number;
        }

        private void Divide( int dividend , int divisor , out int quotient , out int remainder )
        {
            quotient = dividend / divisor;
            remainder = dividend % divisor;
        }

        private void PrintArray( in int [] arr )
        {
            for ( int i = 0 ; i < arr.Length ; i++ )
            {
                Console.Write($"{arr [i]} ");
            }
        }

        public void PrintNumbers( params int [] numbers )
        {
            foreach ( int number in numbers )
            {
                Console.WriteLine(number);
            }
        }
        
        
       
   
    

        private static void Main( string [] args )
        {
            // value types
            int number1 = 5;
            int number2 = number1;
            number2 = 10;
            Console.WriteLine($"number1: {number1}, number2: {number2}");

            // Reference types
            int [] numberArray1 = { 1 , 2 , 3 };
            int [] numberArray2 = numberArray1;
            numberArray2 [0] = 5;
            Console.WriteLine($"numberArray1[0]: {numberArray1 [0]}, numberArray2: {numberArray2 [0]}");
            Fundamentals fundamentals = new Fundamentals( );
            // ref out in
            fundamentals.GetSquare(ref number1);
            Console.WriteLine(number1);

            int dividend = 10;
            int divisor = 3;
            int quotient, remainder;
            fundamentals.Divide(dividend , divisor , out quotient , out remainder);
            Console.WriteLine($"quotient: {quotient}, remainder: {remainder}");
            int [] nums = { 1 , 2 , 3 , 4 , 5 };
            fundamentals.PrintArray(in nums);
            //Strings
            string firstname = "Ali";
            string lastName = "Hassan";
            string fullName = firstname + " " + lastName;
            Console.WriteLine(fullName);
            // string builders
            StringBuilder fullNameStingBuilder = new StringBuilder( );
            fullNameStingBuilder.Append("Ali");
            fullNameStingBuilder.Append(" ");
            fullNameStingBuilder.Append("Hassan");
            string fullNameString = fullNameStingBuilder.ToString( );
            Console.WriteLine(fullNameString);
            // params key word
            fundamentals.PrintNumbers(12 , 45 , 67 , 89 , 56);
            Level myLevel = Level.Medium;
            int level = (int)Level.Low;
            Console.WriteLine(myLevel);
            Console.WriteLine(level);

        }
    }
}