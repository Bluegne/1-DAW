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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Exercise_2_List
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<int> values = new List<int>();
        List<int> evenValues = new List<int>();
        void ReadList (List<int> origList)
        {
            DialogResult addMore;
            int numbers;
            do
            {
                numbers = int.Parse(Interaction.InputBox("Enter a value: "));
                origList.Add(numbers);
                addMore = MessageBox.Show("Do you want to enter another value?", "Value", MessageBoxButtons.YesNo);
            }
            while (addMore == DialogResult.Yes);
        }
        string ShowList(List<int> list) 
        {
            string msg = "";
            for (int i = 0; i < list.Count; i++) 
            {
                msg += list[i] + " | ";
            }
            return msg;

        }
        
        string ShowBothLists(List<int> values, List<int> evenValues) 
        {
            string origList = ShowList(values);
            string evenList = ShowList(evenValues);
            string msg = "";

            if (values.Count > 0 && evenValues.Count == 0)
            {
                msg = "Original list: " + origList;
            }
            else if (evenValues.Count > 0 || values.Count > 0)
            {
                msg = "Original list: " + origList + "\n" + "Even list: " + evenList;
            }
            else if (evenValues.Count == 0)
            {
                msg = "Even list is empty";
            }
            else if (values.Count == 0)
            {
                msg = "Original list is empty";
            }
            else 
            {
                msg = "Both lists are empty";
            }
            return msg;
        }

        void CopyEvenNumbers(List<int> values, List<int> evenValues)
        {
            for (int i = 0; i < values.Count; i++)
            {
                int element = values[i];                
                if (element % 2 == 0)
                {
                    evenValues.Add(values[i]);
                }
            }
        }

        void MoveEvenNumbers(List<int> values, List <int> evenValues)
        {
            int i = 0; 
            while (i < values.Count) 
            {
                if (values[i] % 2 == 0)
                {
                    evenValues.Add(values[i]);
                    values.RemoveAt(i);
                }
                else
                {
                    i++;
                }
            }
        }

        private void btnReadList_Click(object sender, EventArgs e)
        {
            ReadList(values);
        }
        private void btnShowList_Click(object sender, EventArgs e)
        {
            string msg = ShowBothLists(values, evenValues);
            MessageBox.Show(msg);
        }
        private void btnCopyEvenNum_Click(object sender, EventArgs e)
        {
            CopyEvenNumbers(values, evenValues);
        }

        private void btnMoveEvenNum_Click(object sender, EventArgs e)
        {
            evenValues.Clear();
            MoveEvenNumbers(values, evenValues);
        }

    }
}
