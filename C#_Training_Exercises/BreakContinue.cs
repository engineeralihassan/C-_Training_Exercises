namespace C__Training_Exercises
{
    public class BreakContinue
    {
        private static void Main()
        {
            int number = 2;
            for (int i = 0; i < 6; i++)
            {
                if (i == number)
                {
                    Console.WriteLine("Contnue");
                    continue;
                }
                Console.WriteLine(i);

                if (i == 4)
                {
                    Console.WriteLine("Terminate");
                    break;
                }


            }
        }
    }
}
