namespace C__Training_Exercises
{
    public class ArrayPrograms
    {
        public int GetSecondLargerNumber( int [] numbers )
        {
            int largest = numbers [0];
            int secondLargest = int.MinValue;

            foreach ( int number in numbers )
            {
                if ( number > largest )
                {
                    secondLargest = largest;
                    largest = number;
                }
                else if ( number > secondLargest && number < largest )
                {
                    secondLargest = number;
                }
            }
            return secondLargest;
        }

        public void PrintSecondLargest( int number )
        {
            Console.WriteLine(number);
        }

        public int [] FindCommonElements( int [] array1 , int [] array2 )
        {
            int [] result = new int [array1.Length];
            int index = 0;

            for ( int i = 0 ; i < array1.Length ; i++ )
            {
                for ( int j = 0 ; j < array1.Length ; j++ )
                {
                    if ( array1 [i] == array2 [j] )
                    {
                        result [index] = array1 [i];
                        index++;
                        break;
                    }
                }
            }
            return result;
        }

        public void GetCommonElements( int [] commonArray )
        {
            Console.WriteLine("Common elements:");
            foreach ( int element in commonArray )
            {
                Console.Write(element);
            }
        }

        public int GetMaxLength( string [] strArr )
        {
            int maxLength = 0;
            foreach ( string str in strArr )
            {
                int len = str.Length;
                if ( len > maxLength )
                {
                    maxLength = len;
                }
            }
            return maxLength;
        }

        public void PrintMaxLength( int number )
        {
            Console.WriteLine("The length of the " +
           "longest string is: " + number);
        }

        public int GetSumOfAbsoluteDifference( int [] array1 , int [] array2 )
        {
            int sum = 0;
            for ( int i = 0 ; i < array1.Length ; i++ )
            {
                sum += Math.Abs(array1 [i] - array2 [i]);
            }
            return sum;
        }

        public void PrintAbslutesum( int number )
        {
            Console.WriteLine($"The Abslute sum is : {number}");
        }

        public int [] SortArray( int [] array, string choice )
        {
         
            int [] sortedArray = new int [array.Length];
            int temp;
            if ( choice == "1" )
            {
                for ( int i = 0 ; i < array.Length ; i++ )
                {
                    for ( int j = i + 1 ; j < array.Length ; j++ )
                    {
                        if ( array [j] < array [i] )
                        {
                            temp = array [i];
                            array [i] = array [j];
                            array [j] = temp;
                        }
                    }
                }
                sortedArray = array;
            }
            if ( choice == "2" )
            {
                for ( int i = 0 ; i < array.Length ; i++ )
                {
                    for ( int j = i + 1 ; j < array.Length ; j++ )
                    {
                        if ( array [j] > array [i] )
                        {
                            temp = array [i];
                            array [i] = array [j];
                            array [j] = temp;
                        }
                    }
                }
                sortedArray = array;
            }
            return sortedArray;
        }

        public void PrintSortedArray( int [] sortedArray )
        {
            foreach ( int number in sortedArray )
            {
                Console.Write(number + " ");
            }
        }
    }

    public class Arrays
    {
        private static void Main()
        {
            int [] numbers = { 12 , 34 , 56 , 78 , 90 , 45 ,
                    67 , 89 , 45 , 78 , 56 , 34 , 65 };
            Console.WriteLine("Wellcome to the Arrays exercises");
            ArrayPrograms arrayPrograms = new ArrayPrograms( );
            arrayPrograms.PrintSecondLargest(arrayPrograms.GetSecondLargerNumber(numbers));

            int [] array = { 3 , 4 , 5 , 7 , 9 };
            int [] array1 = { 4 , 5 , 7 , 9 , 4 };
            int [] commonArray = arrayPrograms.FindCommonElements(array , array1);
            arrayPrograms.GetCommonElements(commonArray);
            string [] strArr = { "Ali Hassan" , "Want to became a " , "good " , "Full stack developer" };
            arrayPrograms.PrintMaxLength(arrayPrograms.GetMaxLength(strArr));

            arrayPrograms.PrintAbslutesum(arrayPrograms.GetSumOfAbsoluteDifference(array1 , array));
            Console.WriteLine("press 1 for ascending and 2 for descending order");
            string choice = Console.ReadLine( );
            arrayPrograms.PrintSortedArray(arrayPrograms.SortArray(numbers,choice));
        }
    }
}