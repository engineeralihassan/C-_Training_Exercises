namespace OOP__exercises
{
    // Exception Handling is a procedure to handle the exception which occurred during the execution of a program

    public class ExceptionHandling
    {

        public void ExceptionMethod(int number1, int number2)
        {
            int result;
            try
            {

                result = number1 / number2;
                Console.WriteLine($"Result = {result}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Message: {ex.Message}");
                Console.WriteLine($"Source: {ex.Source}");
                Console.WriteLine($"HelpLink: {ex.HelpLink}");
                Console.WriteLine($"StackTrace: {ex.StackTrace}");
            }
        }
        public void MultiExceptionMethod(int number1, int number2)
        {
            int result = 0;


            try
            {

                result = number1 / number2;
                Console.WriteLine($"Result = {result}");
            }

            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine($"Message: {ex.Message}");

            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine($"Message: {ex.Message}");

            }
            catch (FormatException ex)
            {
                Console.WriteLine($"Message: {ex.Message}");

            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Message: {ex.Message}");

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Message: {ex.Message}");

            }
            finally
            {
                Console.WriteLine("We are all set then we see the finally block ");
            }
        }
        public void TrhowException()
        {
            try
            {
                int number = 2;
                int number1 = 0;
                int result = number / number1;
                throw new Exception("A number can not be divided by Zero");

            }
            catch (Exception)
            {
                Console.WriteLine(Exception.ReferenceEquals);
            }
            finally
            {
                Console.WriteLine("Finally runs");
            }
        }
        private static void Main(string[] args)
        {
            // Exception Handle with Logically
            int Number1 = 12, Number2 = 3, Result;

            if (Number2 == 0)
            {
                Console.WriteLine("Second Number Should Not Be Zero");
            }
            else
            {
                Result = Number1 / Number2;
                Console.WriteLine($"Result = {Result}");
            }
            // Exception Handle by try catch
            ExceptionHandling exceptionHandling = new ExceptionHandling();
            // exceptionHandling.ExceptionMethod(12, 0);
            // exceptionHandling.MultiExceptionMethod(1, 6);
            // exceptionHandling.MultiExceptionMethod(1, 0);
            exceptionHandling.TrhowException();




        }
    }
}