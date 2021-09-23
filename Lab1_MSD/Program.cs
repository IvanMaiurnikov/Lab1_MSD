using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace Lab1_MSD
{
    public class ArrayAssort
    {
        // PUBLIC TYPES
        public enum SORTING_DIR { RND_SORT, ASC_SORT, DESC_SORT };
        public enum SORTING_TYPE { SHAKER_SORT, INSERTION_SORT };

        //PRIVATE VARs
        private int[] arr;
        private SORTING_TYPE SType;
        private SORTING_DIR  SDir;


        //метод обміну елементів
        static void Swap(ref int e1, ref int e2)
        {
            var temp = e1;
            e1 = e2;
            e2 = temp;
        }

        //сортування вставками
        private void InsertionSort(SORTING_DIR Dir)
        {
            bool isSortAsc = (Dir == SORTING_DIR.ASC_SORT) ? true : false;
            var len = arr.Length;
            for (int i = isSortAsc ? 0 : (len - 1);
                isSortAsc ? (i < len) : (i >= 0);
                i += isSortAsc ? 1 : -1)
            {
                var key = arr[i];
                var j = i;
                var inc = isSortAsc ? -1 : 1;
                while (isSortAsc ? ((j > 1) && (arr[j + inc] > key)) : ( j < (len - 1)  && (arr[j + inc] < key)) )
                {
                    Swap(ref arr[j + inc], ref arr[j]);
                    j += inc;
                }

                arr[j] = key;
            }
        }

        private void ShakerSort(SORTING_DIR Dir)
        {

        }

        //PRIVATE FUNCTIONS
        public void SortingAndPrint(SORTING_TYPE t, SORTING_DIR d)
        {
            if( t != SType || d != SDir)
            {

            }
            
        }

        //PUBLIC FUNCTIONS
        public ArrayAssort(int ArraySize, int start, int end, SORTING_DIR d = SORTING_DIR.RND_SORT, SORTING_TYPE t = SORTING_TYPE.INSERTION_SORT)
        {
            arr = new int[ArraySize];
            var rand = new Random();
            for (int i = 0; i < ArraySize; i++)
            {
                arr[i] = rand.Next(start, end+1);
            }
            SDir = d;
            SType = t;
            if (SDir != SORTING_DIR.RND_SORT)
            {
                switch (SType)
                {
                    case SORTING_TYPE.INSERTION_SORT:
                        InsertionSort(SDir);
                        break;

                    case SORTING_TYPE.SHAKER_SORT:

                        break;
                }
            }
        }

    }


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to sorting program!\nChoose the size of array.\n Rows:");
            ArrayAssort arr1 = new ArrayAssort(100, 10, 100, ArrayAssort.SORTING_DIR.ASC_SORT);
        }
    }
}
