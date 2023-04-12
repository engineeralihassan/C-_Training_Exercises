namespace C__Training_Exercises
{
    public class MathOprations
    {
        public int Add( int number1 , int number2 )
        {
            return number1 + number2;
        }

        // Function for Subtract 2 numbers
        public int Subtract( int number1 , int number2 )
        {
            return number1 - number2;
        }

        // Function for Multiply 2 numbers
        public int Multiply( int number1 , int number2 )
        {
            return number1 * number2;
        }

        // Function for Divide 2 numbers
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