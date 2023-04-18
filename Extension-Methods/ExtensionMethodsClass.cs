namespace Extension_Methods
{
    internal static class ExtensionMethodsClass
    {
        public static string GetFullName( this Student studentClassObject )
        {
            return studentClassObject.FirstName + " " + studentClassObject.LastName;
        }

        public static int GetAge( this Student studentClassObject )
        {
            DateTime currentDate = DateTime.Today;

            int age = currentDate.Year - studentClassObject.DateOfBirth.Year;

            return age;
        }

        public static string GetFullName( this Employee employeeClassObject )
        {
            return employeeClassObject.name;
        }

        public static int GetAge( this Employee employeeClassObject )
        {
            return employeeClassObject.age;
        }

        public static string modify( this string str )
        {
            str = str.Replace("is" , "that");
            return str;
        }

        public static Boolean IsEven( this int number )
        {
            if ( number % 2 == 0 )
            {
                return true;
            }
            return false;
        }
    }
}