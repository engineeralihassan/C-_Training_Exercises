namespace C__Training_Exercises
{
    public class MathOprations
    {
        /// <summary>
        /// Adds two integers together and returns the result.
        /// </summary>
        /// <param name="number1">The first integer to add.</param>
        /// <param name="number2">The second integer to add.</param>
        /// <returns>The sum of number1 and number2.</returns>
        public int Add( int number1 , int number2 )
        {
            return number1 + number2;
        }

        /// <summary>
        /// Subtract two integers together and returns the result.
        /// </summary>
        /// <param name="number1">The first integer to subtract.</param>
        /// <param name="number2">The second integer to subtract.</param>
        /// <returns>The subtract result  of number1 and number2.</returns>
        public int Subtract( int number1 , int number2 )
        {
            return number1 - number2;
        }

        /// <summary>
        /// Multiply two integers together and returns the result.
        /// </summary>
        /// <param name="number1">The first integer to multiply.</param>
        /// <param name="number2">The second integer to multiply.</param>
        /// <returns>The Multiply result  of number1 andmultiply.</returns>
        public int Multiply( int number1 , int number2 )
        {
            return number1 * number2;
        }

        /// <summary>
        /// Divide two integers together and returns the result.
        /// </summary>
        /// <param name="number1">The first integer to divide.</param>
        /// <param name="number2">The second integer to divide.</param>
        /// <returns>The divide result  of number1 and number2.</returns>
        public int Divide( int number1 , int number2 )
        {
            return number1 / number2;
        }

        public void GetResults()
        {
            Console.WriteLine("Please Enter First number ");
            int number1 = int.Parse(Console.ReadLine( ));
            Console.WriteLine("Please Enter Second number ");
            int number2 = int.Parse(Console.ReadLine( ));
            Console.WriteLine("Please Enter operator to perform" +
                " operation (+,-,*,/) and press Enter");
            string operationType = Console.ReadLine( );

            switch ( operationType )
            {
                case "+":
                    Console.WriteLine("The sum of {0} and {1} is : {2}" , number1 , number2 , this.Add(number1 , number2));
                    break;

                case "-":
                    Console.WriteLine("The subtraction of {0} and {1} is : {2}" , number1 , number2 , this.Subtract(number1 , number2));
                    break;

                case "*":
                    Console.WriteLine("The multiple  of {0} and {1} is : {2}" , number1 , number2 , this.Multiply(number1 , number2));
                    break;

                case "/":
                    Console.WriteLine("The Division  of {0} and {1} is : {2}" , number1 , number2 , this.Divide(number1 , number2));
                    break;

                default:
                    Console.WriteLine("Please enter right operator  (+,-,*,/) ");
                    break;
            }
        }
    }
}