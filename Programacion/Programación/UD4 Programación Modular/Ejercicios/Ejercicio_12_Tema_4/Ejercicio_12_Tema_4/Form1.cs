using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_12_Tema_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool calcularAnyoBisiesto(int year)
        {
            bool bisiesto = false;
            if (year % 4 == 0)
            {
                bisiesto = true;
                if (year % 100 == 0 && year % 400 != 0)
                {
                    bisiesto = false;
                }
            }
            return bisiesto;
        }
        bool validateDate (int day, int month, int year)
        {
            bool valid = false;
            if (day >= 1 && day <= 31 && month >= 1 && month <= 12 && year >= 1 && year <= 5000)
            {
                if ((month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12) && (day <= 31))
                {
                    valid = true;
                }
                else if ((month == 4 || month == 6 || month == 9 || month == 11) && (day <= 30))
                {
                    valid = true;
                }
                bool bisiesto = calcularAnyoBisiesto(year);
                if (month == 2)
                {
                    if (bisiesto && day >= 1 && day <= 29)
                    valid = true;
                }
            }
            return valid;
        }
        private void btnValidate_Click(object sender, EventArgs e)
        {
            int day = int.Parse(txtDay.Text);
            int month = int.Parse(txtMonth.Text);
            int year = int.Parse(txtYear.Text);
            bool valid = validateDate(day, month, year);

            if (valid == true)
            {
                MessageBox.Show("La fecha es válida");
            }
            if (valid == false)
            {
                MessageBox.Show("La fecha no es válida");
            }
        }
    }
}
