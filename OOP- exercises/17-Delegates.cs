using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP__exercises
{
    public delegate int delegate1( int number1 , int number2 );

    public class Delegates
    {
      
        public int CalculateSum(int number1, int number2)
        {
            return number1 + number2;
        }
        public int CalculateMultiply( int number1 , int number2 )
        {
            return number1 * number2;
        }
        public int Calculatedivision( int number1 , int number2 )
        {
            return number1 / number2;
        }
    }
    public class _17_Delegates
    {
        private static void Main()
        {
            Delegates delegates = new Delegates( );
            delegate1 obj = new delegate1(delegates.CalculateMultiply);
            Console.WriteLine(obj(12 , 45));
            
            



        }
    }
}
