using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Exercise_8_List
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        const int SIZE = 6;
        List<int> winningNum = new List<int>();
        List<int> userNum = new List<int>();

        static void GenerateWinningNum(List<int> list)
        {
            Random rnd = new Random();
            int rndNum = 0;
            string wNum = "The lottery number has been generated :)";
            for(int i = 1; i <= SIZE ; i++)
            {
                rndNum = rnd.Next(1, 50);
                if(!list.Contains(rndNum))
                {
                    list.Add(rndNum);
                }
            }
            MessageBox.Show(wNum);
        }
        string ShowLists (List<int> list) 
        {
            string msg = "";
            foreach(int i in list) 
            {
                msg += i + " | ";
            }
            return msg;
        }

        static void ReadUserNum(List<int> list)
        {
            int userNum = 0;
            int i = 0;
            while (i < SIZE)
            {
                string msg = Interaction.InputBox("Introduce number", "Please enter your lottery numbers");
                while (msg == "")
                { 
                    MessageBox.Show("Error, you have not introuced your lottery numbers, please try again.");
                    msg = Interaction.InputBox("Introduce number", "Please enter your lottery numbers");
                }
                userNum = int.Parse(msg);
                if (userNum >= 1 && userNum <= 49)
                {
                    if (!list.Contains(userNum))
                    {
                        list.Add(userNum);
                        i++;
                    }
                    else
                    {
                        MessageBox.Show("Error, numbers cannot be repeated, please try again.");
                    }
                }
                else
                {
                    MessageBox.Show("Error, numbers have to be between 1 and 49, please try again.");
                }
            }
        }

        string CheckResult (List<int> winningNum, List<int> userNum)
        {
            int accum = 0;
            string msg = "";
            for(int i = 0; i < SIZE; i++)
            {
                if (winningNum.Contains(userNum[i]))
                {
                    accum++;
                }
            }

            switch (accum) 
            {
                case 0: 
                    msg = "Oops, no luck this time... :(";
                    break;
                case 1: 
                    msg = "...You have one match!";
                    break;
                case 2: 
                    msg = "...You have two matches!";
                    break;
                case 3: 
                    msg = "...You have three matches!";
                    break;
                case 4:
                    msg = "...You have four matches!";
                    break;
                case 5:
                    msg = "...You have five matches!";
                    break;
                case 6:
                    msg = "Congratulations, you have won the lottery!!";
                    break;
            }
            return msg;
        }
        private void btnReadWinningNum_Click(object sender, EventArgs e)
        {
            GenerateWinningNum(winningNum);
        }

        private void btnReadUserNum_Click(object sender, EventArgs e)
        {
            ReadUserNum(userNum);
            MessageBox.Show("Lottery numbers introduced correctly, please proceed to check the result.");
        }

        private void btnCheckResults_Click(object sender, EventArgs e)
        {
            string primitiva = ShowLists(winningNum);
            string userNumber = ShowLists(userNum);
            string msg = CheckResult(winningNum, userNum);
            MessageBox.Show("The winning number is: " + primitiva + "\n\nYour lottery number is: " + userNumber + "\n\n" + msg);
        }
    }
}
