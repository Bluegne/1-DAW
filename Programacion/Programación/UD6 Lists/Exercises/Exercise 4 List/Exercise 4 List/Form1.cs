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

namespace Exercise_4_List
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        const int SIZE = 10;

        List<int> baseList= new List<int>();
        List<int> exponentList = new List<int>();
        List<int> powerList = new List<int>();
        void ReadNumbers(List<int> list)
        {
            for(int i = 0; i < SIZE; i++)
            {
                int num = int.Parse(Interaction.InputBox("Please enter a number"));
                list.Add(num);
            }
        }

        int CalculatePower(int baseNum, int expNum)
        {
            int power = 1;
            for(int i = 0; i < expNum; i++)
            {
                power *= baseNum;
            }
            return power;
        }

        void CalculatePowerList (List<int> list1, List<int> list2, List<int> list3) 
        {
            for(int i = 0; i < SIZE ; i++) 
            {
                list3.Add(CalculatePower(list1[i], list2[i]));
            }
        }

        string ShowList(List<int> list)
        {
            string msg = "";
            for(int i = 0; i < SIZE; i++)
            {
                if(msg != "")
                {
                    msg += " | ";
                }
                msg += list[i];
            }
            return msg;
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please introduce the base number");
            ReadNumbers(baseList);
            MessageBox.Show("Please introduce the exponent number");
            ReadNumbers(exponentList);
        }

        private void btnShowList_Click(object sender, EventArgs e)
        {
            ShowList(powerList);
        }
    }
}
