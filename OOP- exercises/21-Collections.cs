using System.Collections;

namespace OOP__exercises
{
    // None Generics collections
    // ArrayList
    internal class ArrayList1
    {
        private ArrayList personalarray = new ArrayList();

        public void AddItem(dynamic item)
        {
            personalarray.Add(item);
        }
        public void InsertItem(int index, dynamic value)
        {
            personalarray.Insert(index, value);
        }
        public void RemoveItem(dynamic item)
        {
            personalarray.Remove(item);
        }

        public void PrintList()
        {
            foreach (dynamic item in personalarray)
            {
                Console.WriteLine(item);
            }
        }
    }

    public class Collections
    {
        private static void Main()
        {
            Console.WriteLine("Non-Generics type collectiosn in c# ");
            ArrayList1 arrayList1 = new ArrayList1();
            arrayList1.AddItem("Ali Hassan");
            arrayList1.AddItem(12);
            arrayList1.AddItem(12.45);
            arrayList1.AddItem(false);
            arrayList1.AddItem(23.5634);
            arrayList1.AddItem(new DateTime());
            arrayList1.PrintList();
            arrayList1.InsertItem(5, "C# Programing language");

            arrayList1.InsertItem(6, 031333324617);
            arrayList1.RemoveItem("Ali Hassan");
            arrayList1.PrintList();


        }

    }
}