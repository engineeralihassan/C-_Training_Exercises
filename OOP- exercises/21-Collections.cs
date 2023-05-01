using System.Collections;

namespace OOP__exercises
{
    // None Generics collections
    // ArrayList
    internal class ArrayList1
    {
        private ArrayList personalarray = new ArrayList();
        public ArrayList evenNumbersList = new ArrayList();

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

        public void GetEvenNumbers(ArrayList list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if ((int)list[i] % 2 == 0)
                {
                    evenNumbersList.Add(list[i]);
                };
            }
        }

        public void PrintList1(dynamic list)
        {
            foreach (dynamic item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
    // Hash Tables 
    class HashTable1
    {
        private Hashtable table = new Hashtable();
        public void AddItem(dynamic key, dynamic value)
        {
            table.Add(key, value);
        }
        public void RemoveItem(dynamic key)
        {
            table.Remove(key);
        }
        public void PrintValue(dynamic key)
        {
            Console.WriteLine($"{key} : {table[key]}");
        }
        public void PrintTable()
        {
            foreach (DictionaryEntry entry in table)
            {
                Console.WriteLine("Key: {0}, Value: {1}", entry.Key, entry.Value);
            }
        }

    }
    // Sorted list 
    class SortList1
    {
        SortedList sortedList = new SortedList();
        public void AddItem(dynamic key, dynamic value)
        {
            sortedList.Add(key, value);
        }
        public void PrintItems()
        {
            foreach (DictionaryEntry item in sortedList)
            {
                Console.WriteLine($"Key : {item.Key} Value : {item.Value}");
            }

        }

    }
    // None Genaric Stack
    class Stack1
    {
        private Stack stack = new Stack();
        public void AddItem(dynamic item)
        {
            stack.Push(item);
        }
        public void DeleteItem()
        {
            stack.Pop();
        }
        public void GetTop()
        {
            stack.Peek();
        }
        public void IsContains(dynamic item)
        {
            string isContain = stack.Contains(item) ? "Yes" : "No";
            Console.WriteLine("The Item is contains is the Stack : {0} ", isContain);
        }

        public void PrintItems()
        {
            foreach (object item in stack)
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
            ArrayList list = new ArrayList();
            list.Add(12);
            list.Add(13);
            list.Add(12);
            list.Add(14);
            list.Add(15);
            list.Add(16);
            list.Add(17);
            list.Add(18);
            list.Add(19);
            list.Add(20);
            list.Add(21);
            list.Add(22);
            arrayList1.GetEvenNumbers(list);
            arrayList1.PrintList1(arrayList1.evenNumbersList);
            // HashTable class 
            HashTable1 hashTable1 = new HashTable1();
            hashTable1.AddItem("name", "Ali Hassan");
            hashTable1.AddItem("age", 12);
            hashTable1.AddItem("Teacher", false);
            hashTable1.AddItem("class", "BSSE-A");
            hashTable1.AddItem("Phone", 03133324617);
            hashTable1.AddItem("cgpa", 3.3);
            hashTable1.AddItem("distance", 120.6);
            hashTable1.RemoveItem("distance");
            hashTable1.PrintValue("cgpa");
            hashTable1.PrintTable();

            // Sorted list 

            SortList1 sortList1 = new SortList1();
            sortList1.AddItem("name", "amjad abbas");
            sortList1.AddItem("age", "21");
            sortList1.AddItem("class", "BSSE-A");
            sortList1.AddItem("phone", 03132345678);
            sortList1.PrintItems();

            // Stack 

            Stack1 stack = new Stack1();
            stack.AddItem("Ali Hassan");
            stack.AddItem("BSSE-A");
            stack.AddItem(5063);
            stack.AddItem("BS-software engineering");
            stack.AddItem(03133324617);
            stack.AddItem("alihassan@gmail.com");
            stack.IsContains(5063);

            // Queue
            Queue queue = new Queue();
            //Adding item to the queue using the Enqueue method
            queue.Enqueue(101);
            queue.Enqueue("Hello");
            queue.Enqueue(3.14f);
            queue.Enqueue(true);
            queue.Enqueue(67.8);
            queue.Enqueue('A');
            //Printing the queue items using foreach loop
            Console.WriteLine($"All Queue Elements: Count {queue.Count}");
            foreach (var item in queue)
            {
                Console.Write($"{item} ");
            }
            //Removing and Returning an item from the queue using the Dequeue method
            Console.WriteLine($"\n\nDeleted Element: {queue.Dequeue()}");
            //Printing item after removing the first added item
            Console.WriteLine($"\nAll Queue Elements After Deletion: Count {queue.Count}");
            foreach (var item in queue)
            {
                Console.Write($"{item} ");
            }
            //Printing Items After Clearing the Queue
            queue.Clear();
            Console.WriteLine($"\n\nQueue Elements After Clear Operation: Count {queue.Count}");
            foreach (var item in queue)
            {
                Console.Write($"{item} ");
            }
            Console.ReadKey();

            //Removing and Returning an item from the queue using the Dequeue method
            Console.WriteLine($"\n\nDeleted Element: {queue.Dequeue()}");
            //Printing item after removing the first added item
            Console.WriteLine($"\nAll Queue Elements After Deletion: Count {queue.Count}");






        }
    }
}