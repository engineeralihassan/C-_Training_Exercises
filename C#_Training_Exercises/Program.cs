using System.Security.Cryptography.X509Certificates;

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

            //MathOprations mathOprations = new MathOprations( );
            //mathOprations.GetResults( );

            //Program program = new Program( );
            //int inputNumber = int.Parse(Console.ReadLine( ));
            //Console.WriteLine(program.CheckEven(inputNumber));

            //Console.WriteLine("Your average Result is {0} % " , program.GetAverage(12 , 34 , 56));
            //Console.WriteLine(program.CheckPrime(inputNumber));

            // Object creation diffrentParameters class 

            DiffrentTYpesParameters diffrentTYpesParameters = new DiffrentTYpesParameters( );
          string information=  diffrentTYpesParameters.GetFullDEtails( 
                "Ali Hassan","BS-software engineering",21.1,true);
            Console.WriteLine(information);
            int[] numbersArray = diffrentTYpesParameters.GetEvenNumbers(45).ToArray();
            Console.WriteLine(numbersArray [1]);

            DiffrentTYpesParameters diffrentTYpesParametersParamtrizedConstructor =
                new DiffrentTYpesParameters(5000.00,1500.00,3000) ;
          Boolean isSenior=diffrentTYpesParametersParamtrizedConstructor.CheckSenior( ) ;
            Console.WriteLine(isSenior ? "Yes Employ is senior":"No you are no senior");
            Console.WriteLine(diffrentTYpesParametersParamtrizedConstructor.IsManagerLevelEmploy(16));












        }
    }
}