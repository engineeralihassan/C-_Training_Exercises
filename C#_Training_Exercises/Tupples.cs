namespace C__Training_Exercises
{
    // C# program to illustrate how to
    // create value tuple using the
    // ValueTuple constructor.

    internal class GFG
    {
        // Main method
        public static void Main()
        {
            // ValueTuple with one element
            ValueTuple<int> ValTpl1 = new ValueTuple<int>(345678);

            // ValueTuple with three elements
            ValueTuple<string , string , int> ValTpl2 = new ValueTuple<string ,
              string , int>("C#" , "Java" , 586);

            // ValueTuple with eight elements
            ValueTuple<int , int , int , int , int , int , int , ValueTuple<int>> ValTpl3 = new ValueTuple<int ,
              int , int , int , int , int , int , ValueTuple<int>>(45 , 67 , 65 , 34 , 34 ,
                34 , 23 , new ValueTuple<int>(90));
        }
    }

    public class GFG1
    {
        private static (int, string, string) TouristDetails()
        {
            return (384645, "Sophite", "USA");
        }
    }

    public class Tupples
    {
        public static void Main()
        {
            // Creating a value tuple with
            // zero element using Create method
            var MyTple1 = ValueTuple.Create( );

            // Using GetHashCode method
            Console.WriteLine("HashCode of a value tuple with " +
                     "zero elements: " + MyTple1.GetHashCode( ));

            // Creating a value tuple
            var MyTple2 = ValueTuple.Create(56 , 3);
            var MyTple3 = ValueTuple.Create(56 , 45);

            // Using CompareTo method
            int res1 = MyTple2.CompareTo(MyTple3);

            // Display result
            Console.WriteLine("CompareTo Method Result: " + res1);
        }
    }
}