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

namespace Exercise_1_List
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List <int> numbers = new List<int>();
        private void btnAdd_Click(object sender, EventArgs e)
        {
            int num = int.Parse(Interaction.InputBox("Enter a number"));
            numbers.Add(num);
            MessageBox.Show("Number added correctly.");
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            int num = int.Parse(Interaction.InputBox("Enter a number"));
            int pos = int.Parse(Interaction.InputBox("Enter a position"));
            if (pos > numbers.Count) 
            {
                MessageBox.Show("Error, the position entered is not valid.");
            }
            else
            {
                numbers.Insert(pos, num);
                MessageBox.Show("Number added correctly.");
            }
        }

        private void btnShowList_Click(object sender, EventArgs e)
        {
            string msg = "The elements inside the list are: " + "\n"; 
            foreach (int num in numbers)
            {
                msg += num + " | ";
            }
            MessageBox.Show(msg);
        }

        private void btnShowFirstPos_Click(object sender, EventArgs e)
        {
            int num = int.Parse(Interaction.InputBox("Enter the number you want to know it's first position"));
            if (numbers.Contains(num))
            {
                int pos = numbers.IndexOf(num);
                MessageBox.Show("The number first position is " + pos);
            }
            else
            {
                MessageBox.Show("Error, the number entered doesn't exist.");
            }
        }

        private void btnShowPositions_Click(object sender, EventArgs e)
        {
            string msg = "";
            int num = int.Parse(Interaction.InputBox("Enter the number you want to know it's positions"));
            if (numbers.Contains(num))
            {
                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i] == num)
                    {
                        msg += i + " | ";
                    }
                }
                MessageBox.Show("The number is located in the positions: " + msg);
            }
            else
            {
                MessageBox.Show("Error, the number entered doesn't exist.");
            }
        }

        private void btnRemoveFirstVal_Click(object sender, EventArgs e)
        {
            int num = int.Parse(Interaction.InputBox("Enter the number you want to remove from its first position"));
            if (numbers.Contains(num))
            {
                numbers.Remove(num);
                MessageBox.Show("Number " + num + " has been successfully removed from the first position.");
            }
            else
            {
                MessageBox.Show("Error, the number entered doesn't exist.");
            }
        }

        private void btnRemoveValues_Click(object sender, EventArgs e)
        {
            int num = int.Parse(Interaction.InputBox("Enter the number you want to remove from all the list"));
            if (!numbers.Contains(num))
            {
                MessageBox.Show("Error, the number entered doesn't exist.");
            }
            else
            {
                while (numbers.Contains(num))
                {
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] == num)
                        {
                            numbers.Remove(num);
                        }
                    }
                }
                MessageBox.Show("Number " + num + " has been successfully removed.");
            }   
        }

        private void btnRemovePosition_Click(object sender, EventArgs e)
        {
            int pos = int.Parse(Interaction.InputBox("Enter the position you want to remove from the list"));
            if (pos > numbers.Count || pos < 0)
            {
                MessageBox.Show("Error, the position entered is not valid.");
            }
            else
            {
                numbers.RemoveAt(pos);
                MessageBox.Show("The position choosen has been removed succesfully.");
            }
        }

        private void btnSortList_Click(object sender, EventArgs e)
        {
            if (numbers.Count > 0)
            {
                numbers.Sort();
                MessageBox.Show("All elements have been sort succesfully.");
            }
            else
            {
                MessageBox.Show("Error, the list is already empty.");
            }
        }

        private void btnRemoveAll_Click(object sender, EventArgs e)
        {
            if (numbers.Count > 0)
            {
                numbers.Clear();
                MessageBox.Show("All elements have been removed succesfully.");
            }
            else
            {
                MessageBox.Show("Error, the list is already empty.");
            }
        }
    }
}
