namespace OOP__exercises
{
    public class GenericsCollections
    {
        private List<string> list = new List<string>();
        private static void Main()
        {
            Console.WriteLine("Generics type collections in c#");
            List<string> countries = new List<string>();

            countries.Add("INDIA");
            countries.Add("USA");
            List<string> newCountries = new List<string>();

            newCountries.Add("JAPAN");
            newCountries.Add("UK");
            countries.AddRange(newCountries);
            Console.WriteLine("Accessing Generic List using For Loop");
            for (int i = 0; i < countries.Count; i++)
            {
                string element = countries[i];
                Console.WriteLine(element);
            }
            //Creating a Generic List of string type and adding
            //elements using collection initializer
            List<string> countries1 = new List<string>
            {
                "INDIA",
                "USA",
                "JAPAN",
                "UK"
            };
            //Accessing List Elements using ForEach Loop
            Console.WriteLine("Accessing Generic List Elemenst using For Each Loop");
            foreach (var item in countries)
            {
                Console.WriteLine(item);
            }
            //Insert Element at Index Position 1
            countries1.Insert(1, "China");
            countries1.InsertRange(2, newCountries);
            //Accessing countries List After InsertRange Method
            Console.WriteLine("\nAccessing List After InsertRange At Index 2");
            foreach (var item in countries1)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\nIs INDIA Exists in List: "
                + countries.Contains("INDIA"));
            Console.WriteLine($"\nRemoving Element SRILANKA :" +
                $" {countries.Remove("SRILANKA")}");
            countries1.RemoveAt(1);
            Console.WriteLine($"\nRemoveAll Method Removes: {countries.RemoveAll(x => x.Length < 3)} Element(s)");
            countries.RemoveRange(0, 2);
        }



    }
}
