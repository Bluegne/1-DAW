using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise_3_objects
{
    internal class Date
    {
        private int mDay;
        private int mMonth;
        private int mYear;

        public Date()
        {
            mDay = 0;
            mMonth = 0;
            mYear = 0;
        }

        public int Day
        {
            get { return mDay; }
            set 
            { 
                if (value >= 1 && value <= 31)
                {
                    mDay = value;
                }
                else
                {
                    MessageBox.Show("Error, fecha inválida");
                }
            }
        }

        public int Month
        {
            get { return mMonth; }
            set 
            {   if (value >= 1 && value <= 12)
                {
                    mMonth = value;
                }
                else
                {
                    MessageBox.Show("Error, fecha inválida");
                }
            }
        }
        public int Year
        {
            get { return (int)mYear; }
            set { mYear = value; }
        }

        private bool CalculateBisiesto (int year)
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

        public bool ValidateDate()
        {
            bool bisiesto = CalculateBisiesto(mYear);
            bool valid = false;
            if (mDay >= 1 && mDay <= 31 && mMonth >= 1 && mMonth <= 12 && mYear >= 1 && mYear <= 5000)
            {
                if ((mMonth == 1 || mMonth == 3 || mMonth == 5 || mMonth == 7 || mMonth == 8 || mMonth == 10 || mMonth == 12) && (mDay <= 31))
                {
                    valid = true;
                }
                else if ((mMonth == 4 || mMonth == 6 || mMonth == 9 || mMonth == 11) && (mDay <= 30))
                {
                    valid = true;
                }
                if (mMonth == 2)
                {
                    if (bisiesto && mDay >= 1 && mDay <= 29)
                        valid = true;
                }
            }
            return valid;
        }

        public string ShowDate()
        {
            string text = "";
            text += mDay + "/" + mMonth + "/" + mYear;
            return text;
        }
    }
}
