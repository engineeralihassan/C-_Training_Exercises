using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP__exercises
{
    public class Employ2
    {
        int id;
        string name = "Ali Hassan";
        private string roll;
        private static int age;
        public static int Age
        {
            set
            {
                age = value;
            }
            get
            {
                return age;
            }

        }
        public string address { set; get; }

        public int Id
        {

            set
            {
                if ( value < 0 )
                {
                    Console.WriteLine("please inter positive number");
                }
                else
                {
                    this.id = value;
                }
            }



            get
            {
                return this.id;
            }
        }
        public string Name
        {
            get
            {
                return this.name;
            }
        }
        public string rollNo
        {
            set
            {
                this.roll = value;
            }
        }
        public class _09_Encapsolations
        {
            private static void Main()
            {
                Employ2 employ = new Employ2( );
                employ.Id = 12;
                employ.address = "Renala khurd okara";
                Console.WriteLine(employ.address);
                Employ2.Age = 12;
                Console.WriteLine(Employ2.Age);

            }
        }
        }
}
