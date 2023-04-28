using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
// Single action is performed in diffrent ways
// like a man is a teacher also a father also a son also 
// every time diffrent acts 
// static and dynamic polimorphism 
// static = compile time polymorphirm
// static = linking the function with an object in compile
// time is called the static polymorphirm
// function overloading | operator overloading
// multiple function definations in the same class or scop = function overloading


namespace OOP__exercises
{
    class Math
    {
        public int Add(int number1, int number2 )
        {
            return number1+ number2;
        }
        public int Add( int number1  )
        {
            return number1 + 10;
        }
        public int Add( int number1 , int number2, int number3 )
        {
            return number1 + number2+ number3;
        }

        public int Add( int number1 , int number2 , string number3 )
        {
            return number1 + number2 + int.Parse(  number3);
        }
       
        public double Add( double number1,double number2 )
        {

            
            return number1+number2;
        }

      
        public double Add( double number1 , double number2 , double number3 )
        {

            return number1 + number2 +number3;
        }


    }
    // Example 2
    class ShoppingCart
    {
        private List<Item> items = new List<Item>();
        public void AddItem( int itemId , string itemName )
        {
            items.Add(new Item(itemId , itemName));
        }

        public void AddItem( int itemId , string itemName , double itemPrice )
        {
            items.Add(new Item(itemId , itemName , itemPrice));
        }

        public void AddItem( int itemId , string itemName , double itemPrice , int quantity )
        {
            items.Add(new Item(itemId , itemName , itemPrice , quantity));
        }

        public void DisplayItems()
        {
            Console.WriteLine("Items in the cart:");

            foreach ( Item item in items )
            {
                Console.WriteLine("ID: {0}, Name: {1}, Price: {2}, Quantity: {3}" ,
                    item.ItemId , item.ItemName , item.ItemPrice , item.Quantity);
            }
        }


    }
    class Item
    {
        public int ItemId { get; set; }
        public string ItemName { get; set; }
        public double ItemPrice { get; set; }
        public int Quantity { get; set; }

        public Item( int itemId , string itemName )
        {
            ItemId = itemId;
            ItemName = itemName;
            ItemPrice = 0;
            Quantity = 1;
        }

        public Item( int itemId , string itemName , double itemPrice )
        {
            ItemId = itemId;
            ItemName = itemName;
            ItemPrice = itemPrice;
            Quantity = 1;
        }

        public Item( int itemId , string itemName , double itemPrice , int quantity )
        {
            ItemId = itemId;
            ItemName = itemName;
            ItemPrice = itemPrice;
            Quantity = quantity;
        }
    }
    // Example 3
    class MeezanBank1
    {
        private int balance;
        public MeezanBank1( int balance )
        {
            this.balance = balance;
        }
        public void Deposit(int depositAmount )
        {
            this.balance = this.balance+depositAmount;
        }
        public void Deposit( double depositAmount )
        {
            this.balance = this.balance + Convert.ToInt32(depositAmount);
        }
        public void   PrintBalance( )
        {
            Console.WriteLine($"Total balance is : {balance}");
        }

    }
    public class _11_Ploymorphism
    {
        private static void Main()
        {
            Math math = new Math();
            int sum1=math.Add(12 , 45);
            int sum2 = math.Add(12 );
            int sum3 = math.Add(12 , 45, 34);
            Console.WriteLine(sum1+ " " + sum2 +" "+ sum3);

            ShoppingCart cart = new ShoppingCart( );

            cart.AddItem(1 , "Item 1");
            cart.AddItem(2 , "Item 2" , 10.99);
            cart.AddItem(3 , "Item 3" , 20.50 , 2);

            cart.DisplayItems( );
            // 3rd example
            MeezanBank1 bank = new MeezanBank1(123456);
            bank.Deposit(1232);
            bank.Deposit(1235.78);
            bank.PrintBalance( );



        }
    }
}
