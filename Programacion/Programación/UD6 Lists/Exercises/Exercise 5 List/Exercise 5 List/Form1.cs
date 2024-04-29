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

namespace Exercise_5_List
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<int> list1 = new List<int>();
        List<int> list2 = new List<int>();
        List<int> list3 = new List<int>();

        void ReadList(List<int> list1)
        {
            DialogResult addMore;
            int num;
            do
            {
                num = int.Parse(Interaction.InputBox("Enter a value: "));
                list1.Add(num);
                addMore = MessageBox.Show("Do you want to enter another value?", "Value", MessageBoxButtons.YesNo);
            }
            while (addMore == DialogResult.Yes);
        }

        string ShowList(List<int> list)
        {
            string msg = "";
            foreach (int i in list)
            {
                msg += i + " | ";
            }
            return msg;
        }

        void MergeAndSortList(List<int> list1, List<int> list2, List<int> list3)
        {
            int i = 0;
            int j = 0;

            while (i < list1.Count && j < list2.Count)
            {
                if (list1[i] < list2[j])
                {
                    list3.Add(list1[i]);
                    i++;
                }
                else 
                {
                    list3.Add(list2[j]);
                    j++;
                }
            }
            while (i < list1.Count)
            {
                list3.Add(list1[i]);
                i++;
            }
            while (j < list2.Count)
            {
                list3.Add(list2[j]);
                j++;
            }
        }

        private void btnReadList_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please enter values for the First List");
            ReadList(list1);
            list1.Sort();
            MessageBox.Show("Please enter values for the Second List");
            ReadList(list2);
            list2.Sort();
        }

        private void btnShowList_Click(object sender, EventArgs e)
        {
            MessageBox.Show("First List: " + ShowList(list1) + "\nSecond List: " + ShowList(list2));
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            MergeAndSortList(list1, list2, list3);
        }

        private void btnMergeAndMove_Click(object sender, EventArgs e)
        {
            list1.Clear();
            list2.Clear();
            MergeAndSortList(list1, list2, list3);
            MessageBox.Show("First List: " + ShowList(list1) + "\nSecond List: " + ShowList(list2) + "\nThird List: " + ShowList(list3));
        }
    }
}
