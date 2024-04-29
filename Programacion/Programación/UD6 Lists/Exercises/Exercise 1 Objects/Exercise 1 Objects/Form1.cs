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

namespace Exercise_1_Objects
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Employee emp = new Employee();
        private void btnEnterData_Click(object sender, EventArgs e)
        {
            //TODO pedir nombre de empleado
            emp.Name = Interaction.InputBox("Enter the employee name.");
            //TODO pedir edad de empleado
            emp.Age = int.Parse(Interaction.InputBox("Enter the employee age"));
        }

        private void btnShowData_Click(object sender, EventArgs e)
        {
            MessageBox.Show(emp.ShowData());
        }

        private void btnEmployeeBirthday_Click(object sender, EventArgs e)
        {
            emp.Birthday();
        }

        private void btnAddSale_Click(object sender, EventArgs e)
        {
            double sale = double.Parse(Interaction.InputBox("Enter the sale."));
            emp.AddSale(sale);
        }
    }
}
