namespace C__Training_Exercises
{
    public class DiffrentTYpesParameters
    {
        private Boolean seniorEmploy = false;
        public double salary;
        public double bounus;
        public int houseRent;
        public double percentage;
       public DiffrentTYpesParameters(double salry, double bonus, int rent)
        {
            this.houseRent = rent;
            this.salary=salry;
            this.bounus = bonus;

        }
       public DiffrentTYpesParameters()
        {

        }

        public double GetPercentage()
        {
            double sum = this.salary + this.bounus + this.houseRent;
            double maxPosibleValue = 100 * 3;

            this.percentage = ( sum / maxPosibleValue ) * 100;

            return percentage;
        }

        public Boolean CheckSenior()
        {
            double averageSalery = this.GetPercentage( );
            if ( averageSalery > 80.5 )
            {
                this.seniorEmploy = true;
                return this.seniorEmploy;
            }
            return this.seniorEmploy;
        }

        public string IsManagerLevelEmploy( int scale )

        {
            Boolean isSenior = this.CheckSenior( );
            if ( isSenior && scale < 17 && scale > 15 )
            {
                return "You are near to promote managers level";
            }
            else if ( isSenior && scale >= 17 )
            {
                return "You are the Employ of Managers Level";
            }
            return "You are not managers Level Employ ";
        }

        public string GetFullDEtails( string name , string education , double age , Boolean student )
        {
            string checkStudent = student ? "a student" : "not a student";

            return $"You name is {name} and you are {age} years old your education" +
                $" is {education} and you currently {checkStudent}  ";
        }
    }
}