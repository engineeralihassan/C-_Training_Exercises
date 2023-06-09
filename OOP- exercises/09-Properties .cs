﻿namespace OOP__exercises
{
    internal class Employ
    {
        private int id;
        private string name;

        // readonly
        private long cnic;

        // write only
        private int balance = 23456789;

        public Employ()
        { }

        public void PrintBalance()
        {
            Console.WriteLine("Balance is : {0}" , balance);
        }

        public Employ( long cnic )
        {
            this.cnic = cnic;
        }

        // getter method
        public void PrintCnic()
        {
            Console.WriteLine("The CNIC is : {0}" , this.cnic);
        }

        // setter function
        public void SetDetails( int id , string name )
        {
            if ( id > 0 )
            {
                this.id = id;
                this.name = name;
            }
            else
            {
                Console.WriteLine("please enter positive id");
            }
        }

        public void PrintDetails()
        {
            Console.WriteLine($"Id: {id} Name : {name}");
        }
    }

    //

    public class _09_Properties
    {
        private static void Main( string [] args )
        {
            Console.WriteLine("Wellcome to the C# Encapsulations world");
            Employ employ = new Employ(123456789098);
            employ.SetDetails(12 , "Amjad sabri");
            employ.PrintDetails( );
            employ.PrintCnic( );
            employ.PrintBalance( );
        }
    }
}