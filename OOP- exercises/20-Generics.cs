using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP__exercises
{
    public class Generics1<T>
    {
        T value;
        public void SetValue(T value )
        {
            this.value = value;
        }
        public T GetValue()
        {
            return this.value;
        }
    }
    public class Generics
    {
        public static void CalculateSum<T>(T number1 , T number2 )
        {
            
            Console.WriteLine($"The sum is : {number2.Equals(number2)}");

        }
    }
    public  class _20_Generics
    {
        private static void Main()
        {
            Generics.CalculateSum("Ali" , "Hassan");
            Generics1<string> generics1 = new Generics1<string>( );
            generics1.SetValue("Ali Hassan");
            Console.WriteLine(generics1.GetValue());

        }
    }
}
