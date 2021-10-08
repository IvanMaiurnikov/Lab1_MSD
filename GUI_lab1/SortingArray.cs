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
        private string[] statisticMsgs;
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
            Array.Clear(statisticMsgs, 0, statisticMsgs.Length);
            statisticMsgs.Append("*******************\nInsertion method\n Initial state:\n");
            statisticMsgs.Append(string.Join(", ", SortedArr));
            statisticMsgs.Append("{ 0 }\n------------------\n");
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
                    statisticMsgs.Append(string.Join(", ", SortedArr));
                    statisticMsgs.Append("\n");
                }
                statisticMsgs.Append("\n--------------------\n");
                if (j <= 0)
                    ComparesCounter += 1;
                else
                    ComparesCounter += 2;

                SortedArr[j] = key;
            }
            statisticMsgs.Append("\n--------------------------------\nCompares: " + ComparesCounter + " Swaps: " + SwapCounter + "\n");
        }


        public void ShakerSort(SORTING_DIR Dir)
        {
            SortedArr = (int[])InitialArr.Clone();
            bool isSortAsc = (Dir == SORTING_DIR.ASC_SORT) ? true : false;
            SwapCounter = 0;
            ComparesCounter = 0;
            Array.Clear(statisticMsgs, 0, statisticMsgs.Length);
            statisticMsgs.Append("*******************\nShaker method\n Initial state:\n");
            statisticMsgs.Append(string.Join(", ", SortedArr));
            statisticMsgs.Append("\n------------------\n");
            for (var i = 0; i < SortedArr.Length / 2; i++)
            {
                var swapFlag = false;
                // pass from left to right
                statisticMsgs.Append("L->R\n");
                for (var j = i; j < SortedArr.Length - i - 1; j++)
                {
                    if (isSortAsc ? (SortedArr[j] > SortedArr[j + 1]) : (SortedArr[j] < SortedArr[j + 1]))
                    {
                        Swap(ref SortedArr[j], ref SortedArr[j + 1]);
                        swapFlag = true;
                    }
                    ComparesCounter += 1;
                    statisticMsgs.Append(string.Join(", ", SortedArr));
                    statisticMsgs.Append("\n");
                }

                // pass from right to left
                statisticMsgs.Append("R->L\n");
                for (var j = SortedArr.Length - 2 - i; j > i; j--)
                {
                    if (isSortAsc ? (SortedArr[j - 1] > SortedArr[j]) : (SortedArr[j - 1] < SortedArr[j]))
                    {
                        Swap(ref SortedArr[j - 1], ref SortedArr[j]);
                        swapFlag = true;
                    }
                    ComparesCounter += 1;
                    statisticMsgs.Append(string.Join(", ", SortedArr));
                    statisticMsgs.Append("\n");
                }

                // if there were no exchanges, exit
                if (!swapFlag)
                {
                    break;
                }
            }
            statisticMsgs.Append("\n--------------------------------\nCompares: " + ComparesCounter + " Swaps: " + SwapCounter + "\n");
        }

        //PRIVATE FUNCTIONS

        //PUBLIC FUNCTIONS
        public SortingArray()
        {

        }

        public SortingArray(int ArraySize, int start, int end, SORTING_DIR d = SORTING_DIR.RND_SORT, SORTING_TYPE t = SORTING_TYPE.INSERTION_SORT)
        {
            InitialArr = new int[ArraySize];
            var rand = new Random();
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
        }

        public int getSwapCounter()
        {
            return SwapCounter;
        }

        public int getComparesCounter()
        {
            return ComparesCounter;
        }

        public string[] getStatisticMsgs()
        {
            return statisticMsgs;
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
