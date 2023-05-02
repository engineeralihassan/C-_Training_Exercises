namespace OOP__exercises
{
    internal class Boxing_Unboxing
    {
        static void Main()
        {
            Console.WriteLine("Boxing and unBoxing in c#");
            int i = 1;
            Console.WriteLine(i);
            object o = i; // boxing  
            Console.WriteLine(i);
            int j = (int)o; // unboxing  
            Console.WriteLine(j);
        }
    }
}
