using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise_5
{
    internal class EmployeeList
    {
        private List<Employee> mList;

        //TODO constructor de la clase. Inicializamos lista.
        public EmployeeList()
        {
            mList = new List<Employee>();
        }

        public List<Employee> EmployeesList
        {
            get { return mList; }
            set { mList = value; }
        }
        //TODO método para añadir un empleado a la lista.
        public void AddEmployee(string name, int age)
        {
            //TODO se crea un empleado nuevo al darle al botón
            Employee empl = new Employee();
            empl.Name = name;
            empl.Age = age;
            mList.Add(empl);
        }

        //TODO método para buscar un empleado por nombre, devolver posición.
        // de un empleado en la lista. false si no lo encuentra.
        public int SearchEmployee(string name)
        {
            int pos = -1;
            int i = 0;
            bool found = false;
            Employee empl;
            while (i < mList.Count && !found)
            {
                empl = mList[i];
                if (empl.Name == name)
                {
                    pos = i;
                    found = true;
                }
                else
                {
                    i++;
                }
            }
            return pos;
        }
        //TODO método parar borrar empleado por nombre.
        public bool DeleteEmployee(string name)
        {
            int pos = SearchEmployee(name);
            bool found = false;
            if (pos >= 0)
            {
                mList.RemoveAt(pos);
                found = true;
            }
            return found;
        }

        //TODO para mostrar lista empleados.
        public string ShowEmployeeList()
        {
            string text = "Lista de Empleados:\n \n";
            foreach (Employee empl in mList)
            {
                text += empl.ShowData();
            }
            return text;
        }

        //TODO método para añadir venta a empleado.
        public bool AddEmployeeSale(string name, double sale)
        {
            bool found = false;
            int pos = SearchEmployee(name);
            Employee empl;

            if (pos >= 0)
            {
                empl = mList[pos];
                empl.AddSale(sale);
                found = true;
            }
            return found;
        }
        //TODO método para borrar ventas a empleado.
        public void DeleteEmployeeSale(string name)
        {
            int pos = SearchEmployee(name);
            Employee empl;

            if (pos >= 0)
            {
                empl = mList[pos];
                empl.DeleteSales();
            }
        }

        //TODO método para mostrar datos de un empleado.
        public string ShowEmplData(string name)
        {
            Employee empl;
            int pos = SearchEmployee(name);
            string text = "";

            if (pos >= 0)
            {
                empl = mList[pos];
                text = empl.ShowData();
            }
            else
            {
                text = "Error, empleado no encontrado.";
            }
            return text;
        }
        //TODO método comparar nombre empleados
        private bool CompareEmplName(Employee emp1, Employee emp2)
        {
            bool maxName = false;
            if (string.Compare(emp1.Name, emp2.Name) <= 0)
            {
                maxName = true;
            }
            return maxName;
        }
        //TODO método para ordenar empleados por nombre alfabéticamente
        public void SortNamesAlphabetically()
        {
            for (int i = 0; i < mList.Count; i++)
            {
                for (int j = i + 1; j < mList.Count; j++)
                {
                    if (CompareEmplName(mList[j], mList[i]))
                    {
                        Employee empl = mList[i];
                        mList[i] = mList[j];
                        mList[j] = empl;
                    }
                }
            }
        }

        //TODO Método para obtener el índice del empleado con las mayores ventas
        public int SortByHigherSales()
        {
            double highestSales = 0;
            int topSalesIndex = -1;
            
            foreach (Employee empl in mList)
            {
                double actualSales = empl.CalculateSales();

                if (actualSales > highestSales)
                {
                    highestSales = actualSales;
                    topSalesIndex = mList.IndexOf(empl);
                }
            }
            return topSalesIndex;
        }
        //TODO método para comparar ventas de los empleados
        private bool CompareEmplSales(Employee emp1, Employee emp2)
        {
            double salesEmpl1 = emp1.CalculateSales();
            double salesEmpl2 = emp2.CalculateSales();

            return salesEmpl1 > salesEmpl2;
        }

        //TODO Método para ordenar las ventas de los empleados
        public void OrderSales()
        {
            for (int i = 0; i < mList.Count - 1; i++)
            {
                for (int j = i + 1; j < mList.Count; j++)
                {
                    if (CompareEmplSales(mList[j], mList[i]))
                    {
                        Employee empl = mList[i];
                        mList[i] = mList[j];
                        mList[j] = empl;
                    }
                }
            }
        }
    }
}
