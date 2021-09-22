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
        //PRIVATE FUNCTIONS
        private void Sorting(int[] InArray, SORTING_DIR Dir, SORTING_TYPE SType)
        {
            for (int i = (Dir == SORTING_DIR.ASC_SORT) ? 0 : (InArray.Length - 1); 
                (Dir == SORTING_DIR.ASC_SORT) ? (i < InArray.Length) : ( i >= 0); 
                i += (Dir==SORTING_DIR.ASC_SORT) ? 1 : -1)
            {

            }
        
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
