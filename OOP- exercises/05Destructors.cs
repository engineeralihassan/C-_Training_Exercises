using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP__exercises
{

    class Complex
    {

     
        int real, img;

       
        public Complex()
        {
            real = 0;
            img = 0;
        }

      
        public void SetValue( int r , int i )
        {
            real = r;
            img = i;
        }

      
        public void DisplayValue()
        {
            Console.WriteLine("Real = " + real);
            Console.WriteLine("Imaginary = " + img);
        }

       
        ~Complex()
        {
            Console.WriteLine("Destructor was called");
        }

    } 
    public class Destructors
    {
        public Destructors() {
            Console.WriteLine("Contructors is running ");
        }
        private static void Main()
        {
            Destructors destructors = new Destructors();
            Complex complex = new Complex();
            complex.DisplayValue( );
        }
    }

}
