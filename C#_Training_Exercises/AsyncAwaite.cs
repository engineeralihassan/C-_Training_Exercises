namespace C__Training_Exercises
{
    //public class AsyncAwaite
    //{
    //}
    //class AsyncrounouseP
    //{
    //    static void Main(string[] args)
    //    {
    //        Method1();
    //        Method2();
    //        Console.ReadKey();
    //    }

    //    public static async Task Method1()
    //    {
    //        await Task.Run(() =>
    //        {
    //            for (int i = 0; i < 20; i++)
    //            {
    //                Console.WriteLine(" Method 1");
    //                // Do something
    //                Task.Delay(100).Wait();
    //            }
    //        });
    //    }


    //    public static void Method2()
    //    {
    //        for (int i = 0; i < 25; i++)
    //        {
    //            Console.WriteLine(" Method 2");
    //            // Do something
    //            Task.Delay(100).Wait();
    //        }
    //    }
    //}

    class Example2AsyncAwait
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wellcome to the Green Land of " +
                "Asyncronouse Programing in c#");
            callMethod();
            Console.ReadLine();
        }


        public static async void callMethod()
        {
            Console.WriteLine("The function is start");
            int sum = await LoopAndReturnDataAsync();
            Console.WriteLine("The Num is :{0}", sum);




        }

        public static async void DoSomethingAsync()
        {

            Console.WriteLine("Method 2000 is start");
            await Task.Delay(200);


            Console.WriteLine("Async operation completed.1");
        }
        public static async Task<int> GetDataAsync()
        {
            Console.WriteLine("Method 4000 is start");
            await Task.Delay(400);
            Console.WriteLine("Near to return ");


            return 42;
        }

        public static async Task<int> LoopAndReturnDataAsync()
        {
            int result = 34;
            Console.WriteLine("The function Execution start");



            await Task.Delay(3000);


            Console.WriteLine("The function Execution near to end");
            return result;
        }
        public static async Task<int> Method1()
        {
            int count = 0;
            await Task.Run(() =>
            {
                for (int i = 0; i < 100; i++)
                {
                    Console.WriteLine(" Method 1");
                    count += 1;
                }
            });
            return count;
        }

    }


}
