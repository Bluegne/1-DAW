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

namespace Exercise_7_List
{
    public partial class Form1 : Form
    {
        List<string> words = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        void ReadList(List<string> list) 
        {
            string word = Interaction.InputBox("Introduce a word");
            list.Add(word);
            bool inserted = false;
            DialogResult addMore;
            addMore = MessageBox.Show("Do you want to introduce another word?", "Words", MessageBoxButtons.YesNo);
            while(addMore == DialogResult.Yes)
            {
                word = Interaction.InputBox("Introduce a word");
                int i = 0;
                inserted = false;
                while(i < list.Count && !inserted) 
                {
                    if(string.Compare(word, list[i]) <= 0)
                    {
                        list.Insert(i, word);
                        inserted = true;
                    }
                    else 
                    {
                        i++;
                    }
                }
                if (!inserted)
                {
                    list.Add(word);
                }
                addMore =  MessageBox.Show("Do you want to introduce another word?", "Words", MessageBoxButtons.YesNo);
            }
        }

        string ShowList(List<string> list) 
        {
            string msg = "";
            foreach (string element in list) 
            {
                msg+= element + ", ";
            }
            return msg;
        }
        private void btnRead_Click(object sender, EventArgs e)
        {
            ReadList(words);
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            MessageBox.Show(ShowList(words));
        }
    }
}
