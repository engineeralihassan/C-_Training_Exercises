using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP__exercises
{
    public class ConstOverloading
    {
        string name;
        int age;
       public ConstOverloading()
        {
            
        }
        public ConstOverloading(string name , int age )
        {
            this.age = age;
            this.name = name;
        }
        public void GetDetails()
        {
            Console.WriteLine($"name : {name} age : {age}");
        }
    }
    class BankAlHabib
    {
        private long acountnumber ;
        private int balance;
        private string acountType;
      public  BankAlHabib(long acountNumber,int balance , string acounttype)
        {
            this.acountnumber = acountNumber;
            this.balance = balance;
            this.acountType = acounttype;
            Console.WriteLine($"Acount number : {this.acountnumber}" +
                $" Balance : {balance} acount type : {acountType} ");

        }

    }

    class Second
    {
        private static void Main()
        {
            ConstOverloading constOverloading = new ConstOverloading();
            ConstOverloading constOverloading1 = new ConstOverloading("Ali Hassa" +
                "n",21);
            constOverloading1.GetDetails( );

        } 
    }
}
