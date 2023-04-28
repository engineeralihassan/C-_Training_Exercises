using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP__exercises
{
    // simple/ binary   operators overloading
    class Operators
    {
        public string firstName;
        public string lastName;
        public static Operators operator + (Operators left, Operators right)
        {
            Operators result = new Operators();
            result.firstName = left.firstName+ right.firstName;
            return result;
        }

        // simple  operators overloading

    }
    // simple  operators overloading
    class Calculator1
    {
       public int number1, number2;
        public Calculator1( int number1 , int number2) { 
            this.number1 = number1;

            this.number2 = number2;
        }
        // operator overloading methods
        public static Calculator1 operator -(Calculator1 classObject )
        {
            classObject.number1 = -classObject.number1;
            classObject.number2 = -classObject.number2;
            return classObject;
        }
        public void Print()
        {
            Console.WriteLine("Number1 = " + number1);
            Console.WriteLine("Number2 = " + number2);
        }

    }

    public class _12_OperatorOverloading
    {
        private static void Main()
        {
            Operators operators = new Operators();
            operators.firstName = "Ali";
            Operators operators1 = new Operators( );
            operators1.firstName = "Hassan";
            Operators operators2 = new Operators( );
            operators2 = operators + operators1;
            Console.WriteLine(operators2.firstName);

            // unary operators 
            Calculator1 calculator1 = new Calculator1(12 , 45);
            calculator1 = -calculator1;
            calculator1.Print( );
            calculator1 = -calculator1;
            calculator1.Print( );






        }

    }
}
