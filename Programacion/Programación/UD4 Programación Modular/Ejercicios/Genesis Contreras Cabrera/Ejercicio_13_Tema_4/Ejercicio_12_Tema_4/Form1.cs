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
        bool validateDate(int day, int month, int year)
        {
            bool valid = false;
            if (day >= 1 && day <= 31 && month >= 1 && month <= 12 && year >= 1 && year <= 5000)
            {
                bool bisiesto = calcularAnyoBisiesto(year);
                if ((month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12) && (day <= 31))
                {
                    valid = true;
                }
                else if ((month == 4 || month == 6 || month == 9 || month == 11) && (day <= 30))
                {
                    valid = true;
                }
                else if ((month == 2) && (bisiesto == true && day <= 29) || (bisiesto == false && day <= 28))
                {
                    valid = true;
                }
            }
            return valid;
        }

        void calculateNextDate(ref int day, ref int month, ref int year)
        {
            bool validate = validateDate(day, month, year);
            bool bisiesto = calcularAnyoBisiesto(year);
            if (validate)
            {
                if ((month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10) && (day <= 31))
                {
                    day = day + 1;
                    if (day > 31)
                    {
                        day = 1;
                        month = month + 1;
                    }
                }
                else if ((month == 4 || month == 6 || month == 9 || month == 11) && (day <= 30))
                {
                    day = day + 1;
                    if (day > 30)
                    {
                        day = 1;
                        month = month + 1;
                    }
                }
                else if (month == 2)
                {
                    day = day + 1;
                    if (bisiesto == true)
                    {
                        if (day > 29)
                        {
                            day = 1;
                            month = month + 1;
                        }
                    }
                    else
                    {
                        if (day > 28)
                        {
                            day = 1;
                            month = month + 1;
                        }
                    }
                }
                if ((month == 12) && (day <= 31))
                {
                    day = day + 1;
                    if (day > 31)
                    {
                        day = 1;
                        month = 1;
                        year = year + 1;
                    }
                }
            }
        }
        private void btnValidate_Click(object sender, EventArgs e)
        {
            int day = int.Parse(txtDay.Text);
            int month = int.Parse(txtMonth.Text);
            int year = int.Parse(txtYear.Text);
            bool validate = validateDate(day, month, year);
            calculateNextDate(ref day, ref month, ref year);
            if (validate)
            {
                MessageBox.Show("La fecha siguiente es " + day + " / " + month + " / " + year);
            }
            else
            {
                MessageBox.Show("Error, fecha inválida");
            }
        }
    }
}
