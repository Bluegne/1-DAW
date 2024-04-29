using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Windows.Forms.VisualStyles;

namespace Exercise_3_List
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<int> numbers = new List<int>();
        List<int> primeNumbers = new List<int>();
        void ReadList(List<int> origList)
        {
            DialogResult addMore;
            int num;
            do
            {
                num = int.Parse(Interaction.InputBox("Enter a value: "));
                origList.Add(num);
                addMore = MessageBox.Show("Do you want to enter another value?", "Value", MessageBoxButtons.YesNo);
            }
            while (addMore == DialogResult.Yes);
        }

        bool FindPrimeNumber (int num)
        {
            bool found = true;
            if (num == 1)
            {
                found = false;
            }
            else
            {
               for(int i = 2; i <= num/2 && found; i ++)
                { 
                    if (num % i == 0)
                    {
                        found = false;
                    }
                }
            }
            return found;
        }
        string ShowList(List<int> origList) 
        {
            string msg = "";
            foreach(int i in origList)
            {
                msg += origList[i] + " | ";
            }
            return msg;
        }
        string ShowBothLists(List<int> numbers, List<int> primeNumbers)
        {
            string msg = "";
            string origList = ShowList(numbers);
            string primeList = ShowList(primeNumbers);

            if (numbers.Count >= 0 && primeNumbers.Count == 0)
            {
                msg = "Original list: " + origList;
            }
            else if (numbers.Count >= 0 && primeNumbers.Count >= 0)
            {
                msg = "Original list: " + origList + "\n" + "Prime list: " + primeNumbers;
            }
            else if (numbers.Count == 0)
            {
                msg = "Original list is empty";
            }
            else if (primeNumbers.Count == 0)
            {
                msg = "Prime list is empty";
            }
            else
            {
                msg = "Both lists are empty";
            }
            return msg;
        }

        void CopyPrimeNumbers(List<int> numbers, List<int> primeNumbers)
        { 
            foreach(int i in numbers)
            {
                bool found = FindPrimeNumber(i);
                if (found)
                {
                    primeNumbers.Add(numbers[i]);
                }
            }
        }

        void MoveNumbers(List<int> numbers, List<int> primeNumbers)
        {
            int i = 0;
            while (i < numbers.Count)   
            {
                if (FindPrimeNumber(numbers[i]))
                {
                    primeNumbers.Add(i);
                    numbers.RemoveAt(i);
                }
                else
                {
                    i++;
                }
            }
        }

        private void btnReadList_Click(object sender, EventArgs e)
        {
            ReadList(numbers);
        }

        private void btnShowList_Click(object sender, EventArgs e)
        {
            ShowList(numbers);
            ShowBothLists(numbers, primeNumbers);
        }

        private void btnCopyPrimeNum_Click(object sender, EventArgs e)
        {
            primeNumbers.Clear();
            CopyPrimeNumbers(numbers, primeNumbers);
        }

        private void btnMovePrimeNum_Click(object sender, EventArgs e)
        {
            MoveNumbers(numbers, primeNumbers);
        }
    }
}
