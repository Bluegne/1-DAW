using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        EmployeeList company = new EmployeeList();

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            string name = Interaction.InputBox("Introduzca el nombre del empleado.");
            name = name.ToUpper();
            int age = int.Parse(Interaction.InputBox("Introduzca la edad del empleado."));
            company.AddEmployee(name, age);
            MessageBox.Show("El empleado " + "'" + name + "'" + " ha sido agregado correctamente.");
        }

        private void btnShowEmpList_Click(object sender, EventArgs e)
        {
            string text = company.ShowEmployeeList();
            MessageBox.Show(text);
        }

        private void btnShowEmplData_Click(object sender, EventArgs e)
        {
            string name;
            string text;

            name = Interaction.InputBox("Indica el nombre del empleado.");
            name = name.ToUpper();
            text = company.ShowEmplData(name);
            MessageBox.Show(text);
        }

        private void btnDeleteEmployee_Click(object sender, EventArgs e)
        {
            string name = Interaction.InputBox("Introduzca el nombre del empleado que quiere eliminar.");
            name = name.ToUpper();
            bool exists = company.DeleteEmployee(name);
            if(exists)
            {
                MessageBox.Show("El empleado " + "'" + name + "'" + " ha sido eliminado correctamente.");
            }
            else
            {
                MessageBox.Show("Error, el empleado no se encuentra en la lista.");
            }
        }

        private void btnAddSaleToEmpl_Click(object sender, EventArgs e)
        {
            string name = Interaction.InputBox("Introduce nombre del empleado al que le desea agregar una venta.");
            name = name.ToUpper();
            int pos = company.SearchEmployee(name);
            if(pos >= 0)
            {
                double sale = double.Parse(Interaction.InputBox("Introduce importe de la venta."));
                company.AddEmployeeSale(name, sale);
                MessageBox.Show("Se ha agregado correctamente a " + "'" + name + "'" + " una venta por un importe de " + sale + "€.");
            }
            else
            {
                MessageBox.Show("Error, el empleado no se encuentra en la lista.");
            }
        }

        private void btnDeleteSalesEmpl_Click(object sender, EventArgs e)
        {
            string name = Interaction.InputBox("Introduce nombre del empleado al que le desea eliminar todas las ventas.");
            name = name.ToUpper();
            int pos = company.SearchEmployee(name);
            if(pos >= 0) 
            {
                company.DeleteEmployeeSale(name);
                MessageBox.Show("Se han eliminado al empleado " + "'" + name + "'" + " todas las ventas de manera exitosa.");
            }
            else
            {
                MessageBox.Show("Error, el empleado no se encuentra en la lista o no tiene ventas registradas.");
            }
        }

        private void btnOrderEmployee_Click(object sender, EventArgs e)
        {
            company.SortNamesAlphabetically();
            MessageBox.Show("Se ha ordenado correctamente.");
        }

        private void btnShowEmplHigherSale_Click(object sender, EventArgs e)
        {
            int topSalesIndex = company.SortByHigherSales();
            if (topSalesIndex >= 0)
            {
                Employee topSalesEmployee = company.EmployeesList[topSalesIndex];
                MessageBox.Show("El empleado con más ventas es: " + "'" + topSalesEmployee.Name + "'.");
            }
            else
            {
                MessageBox.Show("No se encontraron empleados con ventas.");
            }
        }

        private void btnOrderEmplBySales_Click(object sender, EventArgs e)
        {
            company.OrderSales();
            MessageBox.Show("Se ha ordenado correctamente.");
        }
    }
}
