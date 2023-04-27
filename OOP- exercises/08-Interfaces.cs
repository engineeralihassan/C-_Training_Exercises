/*
 * Like a class, Interface can have methods, properties, events, and indexers as its members. But interfaces will contain only the declaration of the members. The implementation of the interface’s members will be given by class who implements the interface implicitly or explicitly.

Interfaces specify what a class must do and not how.
Interfaces can’t have private members.
By default all the members of Interface are public and abstract.
The interface will always defined with the help of keyword ‘interface‘.
Interface cannot contain fields because they represent a particular implementation of data.
Multiple inheritance is possible with the help of Interfaces but not with classes.
 */

namespace OOP__exercises
{
    internal interface IShap
    {
        int CalculateArea();

        int GetArea();
    }
    // Example 2 
    interface vehicle
    {
        int ChangeGear(int gear);
        int IncreaseSpeed(int speed);
        int DecreaseSpeed(int speed);

    }
    public class Place : IShap
    {
        public int length;
        public int width;
        public int area;

        public Place( int length , int width )
        {
            this.length = length;
            this.width = width;
        }

        public int CalculateArea()
        {
            return this.length * this.width;
        }

        public int GetArea()
        {
            this.area = CalculateArea( );
            return this.area;
        }
    }
    public class Traler : vehicle
    {
        int speed;
        int gear;
        public void SetProperties(int gear, int speed)
        {
            this.gear = gear;
            this.speed = speed;
        }
        public int ChangeGear( int gear )
        {
            this.gear = gear;
            return this.gear;
        }
       public int IncreaseSpeed( int speed )
        {
            this.speed=this.speed+speed;
            return this.speed;
        }
       public int DecreaseSpeed( int speed )
        {
            this.gear=this.speed-speed;
            return this.speed;
        }
        public void PrintStates()
        {
            Console.WriteLine("The current speed is : {0} and Gear is {1}",this.speed,this.gear);
        }
    }
    /// <summary>
    /// Implicit interfaces
    /// </summary>
    /// 
    interface interface1
    {
        void show();
        void GetAge( int age );

    }
    interface interface2
    {
        void show();
        void GetAge( int age , double birthYear );
    }
    interface interface3
    {
        void show();
        void GetAge( int age , int birthYear );
    }
    interface interface4
    {
        void show();
    }
    public class Parent : interface1, interface2, interface3
    {
        public void show()
        {
            Console.WriteLine("This is the show method that represents the all of the interfaces ");
        }

        public void GetAge( int age , double birthYear )
        {
            Console.WriteLine("This is the Method of interface 2");
        }
        public void GetAge( int age , int birthYear )
        {
            Console.WriteLine("This is the Method of interface 3");
        }
        public void GetAge( int age )
        {
            Console.WriteLine("This is the Method of interface 1");
        }

    }
    public class _08_Interfaces
    {
        private static void Main()
        {
            Console.WriteLine("The Interfaces in c# ");
            Place place = new Place(12 , 34);
            place.CalculateArea( );
            Console.WriteLine("The area is : {0}" , place.GetArea( ));
            // Example 2
            Traler traler = new Traler();
            traler.SetProperties(2 , 60);
            traler.PrintStates( );
            traler.ChangeGear(4);
            traler.PrintStates( );
            // implicit interfaces
            Console.WriteLine("Implicit interfaces in  C# ");
            Parent parent = new Parent( );
            parent.show( );
            parent.GetAge(12);
            parent.GetAge(12 , 34);
            parent.GetAge(12 , 45.7);
            // Question : 
            interface2 interface2obj = new Parent( );
            interface2obj.show( );
            // question if we want to make the class methos with same signature 

        }
    }
}