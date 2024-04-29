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

namespace Exercise_3_objects
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Date> dateList = new List<Date>();
        
        public void AddDate()
        {
            Date date = new Date();
            date.Year = int.Parse(Interaction.InputBox("Introduce el año"));
            date.Month = int.Parse(Interaction.InputBox("Introduce el mes"));
            date.Day = int.Parse(Interaction.InputBox("Introduce el día"));

            if (date.ValidateDate())
            {
                dateList.Add(date);
            }
            else
            {
                MessageBox.Show("Error, fecha inválida.");
            }
        }

        bool CompareDate(Date firstDate, Date secondDate)
        {
            int dayOne = firstDate.Day;
            int dayTwo = secondDate.Day;
            bool minDate = false;

            if (firstDate.Year < secondDate.Year)
            {
                minDate = true;
            }
            if ()
            
            return minDate;
        }
        void OrderDate(List<Date> dateList)
        {
            for (int i = 0; i < dateList.Count; i++)
            {
                for (int j = i + 1; j < dateList.Count; j++) 
                {
                    
                }
            }
        }

        string ListDate(List<Date> dateList)
        {
            string text = "";
            foreach (Date date in dateList)
            {
                text += date.ShowDate() + "\n";
            }
            return text;
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            AddDate();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            OrderDate();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            string date = ListDate(dateList);
            MessageBox.Show(date);
        }
    }
}
