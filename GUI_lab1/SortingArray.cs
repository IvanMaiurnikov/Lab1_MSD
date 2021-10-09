using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.MSD
{
    public class SortingArray
    {
        // PUBLIC TYPES
        public enum SORTING_DIR { RND_SORT, ASC_SORT, DESC_SORT };
        public enum SORTING_TYPE { SHAKER_SORT, INSERTION_SORT };

        //PRIVATE VARs
        private int[] InitialArr;
        private int[] SortedArr;
        private List<string> sortingLog;
        private SORTING_TYPE SType;
        private SORTING_DIR SDir;
        private int SwapCounter = 0;
        private int ComparesCounter;
        private string StepString;
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
            SortedArr = (int[])InitialArr.Clone();
            bool isSortAsc = (Dir == SORTING_DIR.ASC_SORT) ? true : false;
            SwapCounter = 0;
            ComparesCounter = 0;
            sortingLog = new List<string> { };
            sortingLog.Add("*******************");
            sortingLog.Add("Insertion method\n Initial state:\n");
            sortingLog.Add(string.Join(", ", SortedArr));
            sortingLog.Add("{ 0 }");
            sortingLog.Add("------------------");
            for (int i = 1; i < SortedArr.Length; i++)
            {
                var key = SortedArr[i];
                var j = i;

                //while ((j > 1) && (isSortAsc ? (SortedArr[j - 1] > key) : (SortedArr[j - 1] < key)))
                while ((j > 0) && (isSortAsc ? (SortedArr[j - 1] > key) : (SortedArr[j - 1] < key)))
                {
                    Swap(ref SortedArr[j - 1], ref SortedArr[j]);
                    j--;
                    ComparesCounter += 1;
                    sortingLog.Add(string.Join(", ", SortedArr));
                }
                sortingLog.Add("--------------------");
                if (j <= 0)
                    ComparesCounter += 1;
                else
                    ComparesCounter += 2;

                SortedArr[j] = key;
            }
            sortingLog.Add("\n--------------------------------");
            sortingLog.Add("Compares: " + ComparesCounter + " Swaps: " + SwapCounter + "\n");
        }


        public void ShakerSort(SORTING_DIR Dir)
        {
            SortedArr = (int[])InitialArr.Clone();
            bool isSortAsc = (Dir == SORTING_DIR.ASC_SORT) ? true : false;
            SwapCounter = 0;
            ComparesCounter = 0;
            sortingLog = new List<string> { };
            sortingLog.Add("*******************\nShaker method\n Initial state:\n");
            sortingLog.Add(string.Join(", ", SortedArr));
            sortingLog.Add("\n------------------\n");
            for (var i = 0; i < SortedArr.Length / 2; i++)
            {
                var swapFlag = false;
                // pass from left to right
                sortingLog.Add("L->R\n");
                for (var j = i; j < SortedArr.Length - i - 1; j++)
                {
                    if (isSortAsc ? (SortedArr[j] > SortedArr[j + 1]) : (SortedArr[j] < SortedArr[j + 1]))
                    {
                        Swap(ref SortedArr[j], ref SortedArr[j + 1]);
                        swapFlag = true;
                    }
                    ComparesCounter += 1;
                    sortingLog.Add(string.Join(", ", SortedArr));
                    sortingLog.Add("\n");
                }

                // pass from right to left
                sortingLog.Add("R->L\n");
                for (var j = SortedArr.Length - 2 - i; j > i; j--)
                {
                    if (isSortAsc ? (SortedArr[j - 1] > SortedArr[j]) : (SortedArr[j - 1] < SortedArr[j]))
                    {
                        Swap(ref SortedArr[j - 1], ref SortedArr[j]);
                        swapFlag = true;
                    }
                    ComparesCounter += 1;
                    sortingLog.Add(string.Join(", ", SortedArr));
                    sortingLog.Add("\n");
                }

                // if there were no exchanges, exit
                if (!swapFlag)
                {
                    break;
                }
            }
            sortingLog.Add("--------------------------------");
            sortingLog.Add("Compares: " + ComparesCounter + " Swaps: " + SwapCounter);
        }

        //PRIVATE FUNCTIONS

        //PUBLIC FUNCTIONS
        public SortingArray()
        {

        }

        public SortingArray(int ArraySize, int start, int end, SORTING_DIR d = SORTING_DIR.RND_SORT, SORTING_TYPE t = SORTING_TYPE.INSERTION_SORT)
        {
            
            generateArray(ArraySize, start, end, d, t);
        }

        public int generateArray(int ArraySize, int start, int end, SORTING_DIR d = SORTING_DIR.RND_SORT, SORTING_TYPE t = SORTING_TYPE.INSERTION_SORT)
        {
            var rand = new Random();
            InitialArr = new int[ArraySize];
            for (int i = 0; i < ArraySize; i++)
            {
                InitialArr[i] = rand.Next(start, end + 1);
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
            return 0;
        }

        public void doSorting(SORTING_TYPE t, SORTING_DIR d)
        {
            switch (t) 
            {
                case SORTING_TYPE.INSERTION_SORT:
                    InsertionSort(d);
                    break;
                case SORTING_TYPE.SHAKER_SORT:
                    ShakerSort(d);
                    break;
                default:
                    break;
            }
                
        }

        public int getSwapCounter()
        {
            return SwapCounter;
        }

        public int getComparesCounter()
        {
            return ComparesCounter;
        }

         public int[] getInitialArr()
        {
            return InitialArr;
        }
        public int[] getSortedArr()
        {
            return SortedArr;
        }
        public List<string> getSortingLog()
        {
            return sortingLog;
        }
    }
    /*
    class Program
    {
        static void Main(string[] args)
        {
            int Inp_size,
                Inp_start,
                Inp_end,
                Inp_Opt;
            Console.WriteLine("Вітаємо у програмі сортуванн!\nВиберіть довжину масиву:");
            Inp_size = Convert.ToInt32(Console.ReadLine());
            // ability to fill array manually
            Console.WriteLine("Початок діапазону:");
            Inp_start = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Кінець діапазону:");
            Inp_end = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Напрямок сортування [0-RANDOM, 1-ASC, 2-DESC]:");
            Inp_end = Convert.ToInt32(Console.ReadLine());
            if (Inp_start < Inp_end)
            {
                Console.WriteLine("Choose the way you want to sort the array[ 1 - Shaker method; 2 - Insertion Sort");

                Inp_Opt = Convert.ToInt32(Console.ReadLine());

                ArrayAssort arr1 = new ArrayAssort(Inp_size, Inp_start, Inp_end, ArrayAssort.SORTING_DIR.ASC_SORT, ArrayAssort.SORTING_TYPE.SHAKER_SORT);
                switch (Inp_Opt)
                {
                    case 1:

                        arr1.InsertionSort(ArrayAssort.SORTING_DIR.DESC_SORT);
                        break;
                    case 2:

                        break;

                }
            }
        }
    }
    */
}
