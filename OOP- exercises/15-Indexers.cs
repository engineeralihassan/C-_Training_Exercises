namespace OOP__exercises
{
    internal class Indexer
    {
        private int [] numbers = new int [4];

        public int this [int index]
        {
            set
            {
                numbers [index] = value;
            }
            get
            {
                return numbers [index];
            }
        }

        public void PrintNumbers()
        {
            foreach ( int i in numbers )
            {
                Console.WriteLine(i);
            }
        }
    }

    internal class MultidimentionalIndexers
    {
        private int [,] multiDimentionarray = new int [2 , 5];

        public int this [int index1 , int index2]
        {
            set
            {
                multiDimentionarray [index1 , index2] = value;
            }
            get
            {
                return multiDimentionarray [index1 , index2];
            }
        }

        public void PrintNumbers()
        {
            for ( int i = 0 ; i < multiDimentionarray.GetLength(0) ; i++ )
            {
                for ( int j = 0 ; j < multiDimentionarray.GetLength(1) ; j++ )
                {
                    Console.WriteLine(multiDimentionarray [i , j]);
                }
            }
        }
    }

    internal class _15_Indexers
    {
        private static void Main()
        {
            Indexer indexer = new Indexer( );
            indexer [0] = 12;
            indexer [1] = 13;
            indexer [2] = 14;
            indexer [3] = 15;

            indexer.PrintNumbers( );
            // 2D indexers
            Console.WriteLine("The multidimentional Indexers");
            MultidimentionalIndexers multidimentionalIndexers = new MultidimentionalIndexers( );
            multidimentionalIndexers [0 , 0] = 12;
            multidimentionalIndexers [0 , 1] = 34;
            multidimentionalIndexers [1 , 0] = 78;
            multidimentionalIndexers [1 , 1] = 23;
            multidimentionalIndexers.PrintNumbers( );
        }
    }
}