using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace Lab1_MSD
{
    public class ArrayAssort
    {
        //PRIVATE VARs
        private int[] arr;

        // PUBLIC TYPES
        public enum SORTING_DIR  { RND_SORT, ASC_SORT, DESC_SORT };
        public enum SORTING_TYPE { SHAKER_SORT, INSERTION_SORT};

        //метод обміну елементів
        static void Swap(ref int e1, ref int e2)
        {
            var temp = e1;
            e1 = e2;
            e2 = temp;
        }

        //сортування вставками
        static int[] InsertionSort(int[] InArray, SORTING_DIR Dir)
        {
            bool isSortAsc = (Dir == SORTING_DIR.ASC_SORT) ? true : false;
            for (int i = isSortAsc ? 0 : (InArray.Length - 1);
                isSortAsc ? (i < InArray.Length) : (i >= 0);
                i += isSortAsc ? 1 : -1)
            {
                var key = InArray[i];
                var j = i;
                var inc = isSortAsc ? -1 : 1;
                while ((j > 1) && (InArray[j - 1] > key))
                {
                    Swap(ref InArray[j - 1], ref InArray[j]);
                    j += inc;
                }

                InArray[j] = key;
            }

            return InArray;
        }

        //PRIVATE FUNCTIONS
        private int[] Sorting(int[] InArray, SORTING_DIR Dir, SORTING_TYPE SType)
        {
            bool isSortAsc = (Dir == SORTING_DIR.ASC_SORT) ? true : false;
            for (int i = isSortAsc ? 0 : (InArray.Length - 1);
                isSortAsc ? (i < InArray.Length) : ( i >= 0); 
                i += isSortAsc ? 1 : -1)
            {

            }
            return InArray;
        }


        //PUBLIC FUNCTIONS
        public ArrayAssort(int ArraySize, int start, int end, SORTING_DIR SDir)
        {
            arr = new int[ArraySize];
            var rand = new Random();
            for (int i = 0; i < ArraySize; i++)
            {
                this.arr[i] = rand.Next(start, end+1);
            }

            switch (SDir)
            {
                case SORTING_DIR.RND_SORT:

                    break;
                case SORTING_DIR.ASC_SORT:

                    break;
                case SORTING_DIR.DESC_SORT:

                    break;
            }
        }

    }


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to sorting program!\nChoose the size of array.\n Rows:");
            ArrayAssort arr1 = new ArrayAssort(100, 3, ArrayAssort.SORTING_DIR.ASC_SORT);
          

        }
    }
}
