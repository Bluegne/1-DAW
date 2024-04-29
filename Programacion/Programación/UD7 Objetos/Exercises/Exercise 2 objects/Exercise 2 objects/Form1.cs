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

namespace Exercise_2_objects
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Person> listPersons = new List<Person>();

        void AddPerson()
        {
            Person person = new Person();
            person.Name = Interaction.InputBox("Introduce nombre");
            person.Age = int.Parse(Interaction.InputBox("Introduce edad"));
            person.Phone = Interaction.InputBox("Introduce número de télefono");
          
            DialogResult status;
            status = MessageBox.Show("Esta casado?", "Estado civil", MessageBoxButtons.YesNo);
            if(status == DialogResult.Yes) 
            {
                person.Status = true;
            }
            else
            {
                person.Status = false; 
            }

            bool added = false;
            while(!added)
            {
                char gender = char.Parse(Interaction.InputBox("Introduce género, M - masculino | F - femenino"));
                if (gender != 'M' || gender != 'F')
                {
                    MessageBox.Show("Error, dato introducido inválido, debe introducir 'M' para masculino o 'F' para femenino");
                }
                else
                {
                    person.Gender = gender;
                    added = true;
                }
            }
            listPersons.Add(person);
        }
        
        string ShowData(List<Person> listPersons)
        {
            Person person;
            string text = "The persons added are: \n";
            for(int i = 0; i < listPersons.Count; i++)
            {
                person = listPersons[i];
                text += person.ShowData();
            }
            return text; 
        }

        private void btnEnterData_Click(object sender, EventArgs e)
        {
            AddPerson();
        }

        private void btnShowData_Click(object sender, EventArgs e)
        {
           ShowData(listPersons);
        }
    }
}
