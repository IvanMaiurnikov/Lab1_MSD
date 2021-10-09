using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lab1.MSD;
namespace GUI_lab1
{
    public partial class ArraySortingForm : Form
    {

        SortingArray sA = new SortingArray();

        public ArraySortingForm()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
        
        private void buttonGenerateArr_Click(object sender, EventArgs e)
        {
            int arrSize = 1;
            int start = 0;
            int end = 10;
            try
            {
                arrSize = Int16.Parse(maskedTextBoxNumElements.Text);
            }
            catch (FormatException)
            {
                Console.WriteLine($"Unable to parse '{maskedTextBoxNumElements.Text}'");
            }
            finally
            {
                if (arrSize < 1) arrSize = 1;
                if (arrSize > 100) arrSize = 100;
                maskedTextBoxNumElements.Text = arrSize.ToString();
            }

            try
            {
                start = Int16.Parse(maskedTextBoxStartVal.Text);
                
            }
            catch (FormatException)
            {
                Console.WriteLine($"Unable to parse '{maskedTextBoxStartVal.Text}'");
            }
            finally
            {
                if (start < 1) start = 1;
                if (start > 100) start = 100;
                maskedTextBoxStartVal.Text = start.ToString();
            }

            try
            {
                end = Int16.Parse(maskedTextBoxEndVal.Text);
            }
            catch (FormatException)
            {
                Console.WriteLine($"Unable to parse '{maskedTextBoxEndVal.Text}'");
            }
            finally
            {
                if (end < 1) end = 1;
                if (end > 100) end = 100;
                maskedTextBoxEndVal.Text = end.ToString();
            }
            //handling radio buttons
            SortingArray.SORTING_DIR d;
            if (radioButtonAssorted.Checked) 
            {
                d = SortingArray.SORTING_DIR.RND_SORT; 
            } 
            else if (radioButtonAsc.Checked)
            {
                d = SortingArray.SORTING_DIR.ASC_SORT;
            }
            else
            {
                d = SortingArray.SORTING_DIR.DESC_SORT;
            }
            SortingArray.SORTING_TYPE t;
            if (radioButtonInsertion.Checked)
            {
                t = SortingArray.SORTING_TYPE.INSERTION_SORT;
            }
            else
            {
                t = SortingArray.SORTING_TYPE.SHAKER_SORT;
            }
            sA.generateArray(arrSize, start, end, d, t);
            int[] res = sA.getInitialArr();
            textBoxAssorted.Text = "";
            textBoxAssorted.AppendText(String.Join(",", res) + Environment.NewLine);
        }

        private void buttonSorting_Click(object sender, EventArgs e)
        {
            SortingArray.SORTING_DIR d;
            if (radioButtonAssorted.Checked)
            {
                d = SortingArray.SORTING_DIR.RND_SORT;
            }
            else if (radioButtonAsc.Checked)
            {
                d = SortingArray.SORTING_DIR.ASC_SORT;
            }
            else
            {
                d = SortingArray.SORTING_DIR.DESC_SORT;
            }
            SortingArray.SORTING_TYPE t;
            if (radioButtonInsertion.Checked)
            {
                t = SortingArray.SORTING_TYPE.INSERTION_SORT;
            }
            else
            {
                t = SortingArray.SORTING_TYPE.SHAKER_SORT;
            }
            sA.doSorting(t, d);
            textBoxSortingLog.Text = "";
            List<string> sL = sA.getSortingLog();
            foreach (string s in sL){
                textBoxSortingLog.Text += s + Environment.NewLine;
            }

            int[] res = sA.getSortedArr();
            textBoxSortedArray.Text = "";
            textBoxSortedArray.AppendText(String.Join(",", res) + Environment.NewLine);
        }
    }
}
