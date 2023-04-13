using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Extension_Methods
{
    static class ExtensionMethodsClass
    {
        public static string GetFullName(this Student  studentClassObject ) 
        {
           
          return  studentClassObject.name;
        }
        public static int GetAge( this  Student  studentClassObject )
        {

            return studentClassObject.age;
        }
        public static string GetFullName( this Employee employeeClassObject )
        {

            return employeeClassObject.name;
        }
        public static int GetAge( this Employee employeeClassObject )
        {

            return employeeClassObject.age;
        }
    }
}
