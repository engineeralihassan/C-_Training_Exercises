namespace C__Training_Exercises
{
    internal class Program
    {
        public string CheckEven( int number )
        {
            string result = number % 2 == 0 ? "The given number is Even" : "The given number  is Odd";
            return result;
        }

        public int GetAverage( params int [] numbers )
        {
            int totalSum = 0;
            foreach ( int number in numbers )
            {
                totalSum = number + totalSum;
            }

            return totalSum / numbers.Length;
        }

        public string CheckPrime( int inputValue )
        {
            Boolean isPrime = true;

            for ( int i = 2 ; i <= inputValue - 1 ; i++ )
            {
                if ( inputValue % i == 0 )
                {
                    isPrime = false;
                    break;
                }
            }
            Console.WriteLine(isPrime);
            string result = isPrime ? "The given number is Prime" : "The given number is not prime";
            return result;
        }

        private static void Main( string [] args )
        {
            Console.WriteLine("Welcome to C# World");

            MathOprations mathOprations = new MathOprations( );
            mathOprations.GetResults( );

            Program program = new Program( );
            int inputNumber = int.Parse(Console.ReadLine( ));
            Console.WriteLine(program.CheckEven(inputNumber));

            Console.WriteLine("Your average Result is {0} % " , program.GetAverage(12 , 34 , 56));
            Console.WriteLine(program.CheckPrime(inputNumber));
        }
    }
}