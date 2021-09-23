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
        private int[] InitialArr;
        private int[] SortedArr;
        private SORTING_TYPE SType;
        private SORTING_DIR  SDir;
        private int SwapCounter = 0;
        private int ComparesCounter;

        //метод обміну елементів
        private void Swap(ref int e1, ref int e2)
        {
            var temp = e1;
            e1 = e2;
            e2 = temp;
            SwapCounter++;

        }

        //сортування вставками
     
        public void InsertionSort(SORTING_DIR Dir)
        {
            SortedArr  = (int[])InitialArr.Clone();
            bool isSortAsc = (Dir == SORTING_DIR.ASC_SORT) ? true : false;
            SwapCounter = 0;
            ComparesCounter = 0;
            for (int i = 1; i < SortedArr.Length; i++)
            {
                var key = SortedArr[i];
                var j = i;

                //while ((j > 1) && (isSortAsc ? (SortedArr[j - 1] > key) : (SortedArr[j - 1] < key)))
                while ((j > 0) && (isSortAsc ? (SortedArr[j - 1] > key) : (SortedArr[j - 1] < key)))
                {
                    Swap(ref SortedArr[j - 1], ref SortedArr[j]);
                    j--;
                    ComparesCounter += 2;
                }

                if(j <= 0)
                    ComparesCounter += 1;
                else
                    ComparesCounter +=2;

                SortedArr[j] = key;
            }
        }
        public void ShakerSort(SORTING_DIR Dir)
        {
            SortedArr = (int[])InitialArr.Clone();
            bool isSortAsc = (Dir == SORTING_DIR.ASC_SORT) ? true : false;
            SwapCounter = 0;
            ComparesCounter = 0;
            for (var i = 0; i < SortedArr.Length / 2; i++)
            {
                var swapFlag = false;
                // pass from left to right
                for (var j = i; j < SortedArr.Length - i - 1; j++)
                {
                    if (isSortAsc ? (SortedArr[j] > SortedArr[j + 1]) : (SortedArr[j] < SortedArr[j + 1]))
                    {
                        Swap(ref SortedArr[j], ref SortedArr[j + 1]);
                        swapFlag = true;
                    }
                    ComparesCounter += 1;
                }

                // pass from right to left
                for (var j = SortedArr.Length - 2 - i; j > i; j--)
                {
                    if (isSortAsc ? (SortedArr[j - 1] > SortedArr[j]) : (SortedArr[j - 1] < SortedArr[j]))
                    {
                        Swap(ref SortedArr[j - 1], ref SortedArr[j]);
                        swapFlag = true;
                    }
                    ComparesCounter += 1;
                }

                // if there were no exchanges, exit
                if (!swapFlag)
                {
                    break;
                }
            }
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
            InitialArr = new int[ArraySize];
            var rand = new Random();
            for (int i = 0; i < ArraySize; i++)
            {
                InitialArr[i] = rand.Next(start, end+1);
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
                        ShakerSort(SDir);
                        break;
                }
                InitialArr = (int[])SortedArr.Clone();
            }
        }

    }


    class Program
    {
        static void Main(string[] args)
        {
            int Inp_size,
                Inp_start,
                Inp_end;
            Console.WriteLine("Вітаємо у програмі сортуванн!\nВиберіть довжину масиву:");
            Inp_size = Convert.ToInt32(Console.ReadLine());
            Inp_start = Convert.ToInt32(Console.ReadLine());
            Inp_end = Convert.ToInt32(Console.ReadLine());
            ArrayAssort arr1 = new ArrayAssort(Inp_size, 100, 200, ArrayAssort.SORTING_DIR.ASC_SORT, ArrayAssort.SORTING_TYPE.SHAKER_SORT);
            arr1.InsertionSort(ArrayAssort.SORTING_DIR.DESC_SORT);
        }
    }
}
