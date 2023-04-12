using System.Security.Cryptography.X509Certificates;

namespace C__Training_Exercises
{
     class Program
    {
      
       public void CheckEven()
        {
            Console.WriteLine("Enter any Number to check The Number is Even or Odd");
            int inputNumber = int.Parse(Console.ReadLine());
            string result = inputNumber % 2 == 0 ? "The given number is Even" : "The given number  is Odd";
            Console.WriteLine(result);
        }
        public int GetEvarage()
        {
            int marksBook1 = 78, marksBook2 = 67, marksBook3 = 89;
            int average = (marksBook1 + marksBook2 + marksBook3) / 3;
            Console.WriteLine("Your average Result is {0} % ", average);
            return average;
        }

        public void CheckPrime()
        {



            Boolean isPrime = true;
            int inputValue;
            do
            {
                Console.WriteLine("Please Enter a number to check Prime or Not ");
                inputValue = int.Parse(Console.ReadLine());
                for (int i = 2; i <= inputValue - 1; i++)
                {
                    if (inputValue % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                Console.WriteLine(isPrime);
                if (isPrime)
                {
                    Console.Write("Number is prime number");
                    Console.WriteLine();
                }
                else
                {
                    Console.Write("Number is not Prime number");
                    Console.WriteLine();
                }



            } while (isPrime);


        }



        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to C# World");

            MathOprations mathOprations = new MathOprations();
            mathOprations.GetResults();

            Program program = new Program();
            program.CheckEven();
            Console.WriteLine("Your average Result is {0} % ", program.GetEvarage());
            program.CheckPrime();
        }
    }
}