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
            // Create new array with 3 elements.
            string[] array = new string[] { "INDIA", "USA", "UK" };
            // Copy the array to a List.
            List<string> copiedList = new List<string>(array);
            Console.WriteLine("Copied Elements in List");
            foreach (var item in copiedList)
            {
                Console.WriteLine(item);
            }

            // Dictionaries
            //Creating a Dictionary with Key and value both are string type
            Dictionary<string, string> dictionaryCountries = new Dictionary<string, string>();
            //Adding Elements to the Dictionary using Add Method of Dictionary class
            dictionaryCountries.Add("UK", "London, Manchester, Birmingham");
            dictionaryCountries.Add("USA", "Chicago, New York, Washington");
            dictionaryCountries.Add("IND", "Mumbai, Delhi, Bhubaneswar");
            Console.WriteLine("Accessing Dictionary Elements using For Each Loop");
            foreach (KeyValuePair<string, string> KVP in dictionaryCountries)
            {
                Console.WriteLine($"Key:{KVP.Key}, Value: {KVP.Value}");
            }
            Console.WriteLine($"Key: USA, Value: {dictionaryCountries["USA"]}");
            Console.WriteLine($"Key: IND, Value: {dictionaryCountries["IND"]}");
            Dictionary<string, string> dictionaryCountries1 = new Dictionary<string, string>
            {
                { "UK", "London, Manchester, Birmingham" },
                { "USA", "Chicago, New York, Washington" },
                { "IND", "Mumbai, Delhi, Bhubaneswar" }
            };
            //Accessing Dictionary Elements using For Each Loop
            Console.WriteLine("Accessing Dictionary Elements using For Each Loop");
            foreach (KeyValuePair<string, string> KVP in dictionaryCountries1)
            {
                Console.WriteLine($"Key:{KVP.Key}, Value: {KVP.Value}");
            }
            Console.WriteLine("Is PAK Key Exists : " + dictionaryCountries1.ContainsKey("PAK"));
            Console.WriteLine("Is Srilanka value Exists : " + dictionaryCountries.ContainsValue("Srilanka"));
            dictionaryCountries.Remove("PAK");

            Console.WriteLine($"Iterating Dictionary Using AsParallel().ForAll Method");
            dictionaryCountries.AsParallel()
            .ForAll(entry => Console.WriteLine(entry.Key + " : " + entry.Value));
        }

    }
}