namespace OOP__exercises
{
    public class _19_LambdaExpresions
    {
        public delegate void LambdaExpresionDelegate();

        private static void Main()

        {
            Console.WriteLine("Welcome to the Lambda expressions world");
            LambdaExpresionDelegate obj = () =>
            {
                Console.WriteLine("This is the lambda expresions ");
            };
            obj( );
            List<int> numbers = new List<int>( ) {36, 71, 12,
                             15, 29, 18, 27, 17, 9, 34};
            var square = numbers.Select(x => x * x);

           
            Console.Write("Squares : ");
            foreach ( var value in square )
            {
                Console.Write("{0} " , value);
            }
        }
    }
}