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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Ejercicio_23_Tema_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcularPeso_Click(object sender, EventArgs e)
        {
            //TODO recoger peso de distintos alumnos de una clase con InputBox
            double peso, pesoMedio, rangoAlumnoA, rangoAlumnoB, rangoAlumnoC, rangoAlumnoD, 
                   totalAlumnos, totalPeso, porcentajeA, porcentajeB, porcentajeC, porcentajeD;
            //TODO recoger rango alumnos dependiendo de peso
            rangoAlumnoA = 0;
            rangoAlumnoB = 0;
            rangoAlumnoC = 0;
            rangoAlumnoD = 0;
            totalAlumnos = 0;
            totalPeso = 0;
            peso = double.Parse(Interaction.InputBox("Introduzca un peso", "Ejercicio 23"));

            //TODO si peso menor o igual que 0, mensaje error 
            if (peso <= 0)
            {
                MessageBox.Show("Error, el peso introducido no puede ser negativo");    
            }
            else
            {
            //TODO si peso mayor que cero, entra en bucle
                while (peso > 0)
                {
                    //TODO si peso <= 50, rangoAlumnoA + 1 
                    if (peso <= 50)
                    {
                        rangoAlumnoA++;
                    }
                    //TODO si peso > 50 y <= 65, rangoAlumnosB + 1
                    else if (peso > 50 && peso <= 65)
                    {
                        rangoAlumnoB++;
                    }
                    //TODO si peso > 65 y <= 80, rangoAlumnosC + 1
                    else if (peso > 65 && peso <= 80)
                    {
                        rangoAlumnoC++;
                    }
                    //TODO si peso < 80, rangoAlumnnoD + 1
                    else if (peso > 80)
                    {
                        rangoAlumnoD++;
                    }
                    //TODO calcular peso total alumnos
                    totalPeso = totalPeso + peso;
                    //TODO calcular total alumnos
                    totalAlumnos++;
                    peso = double.Parse(Interaction.InputBox("Introduzca un peso", "Ejercicio 23"));
                }
            }

            //TODO calcular peso medio total de alumnos
            pesoMedio = totalPeso / totalAlumnos;

            //TODO calcular porcentaje que representan frente al total de alumnos
            porcentajeA = rangoAlumnoA / totalAlumnos * 100;
            porcentajeB = rangoAlumnoB / totalAlumnos * 100;
            porcentajeC = rangoAlumnoC / totalAlumnos * 100;
            porcentajeD = rangoAlumnoD / totalAlumnos * 100;

            MessageBox.Show("Alumnos hasta 50kg: " + rangoAlumnoA + "\n" +
                "Alumnos entre 50kg hasta 65kg: " + rangoAlumnoB + "\n" +
                "Alumnos entre 65kg hasta 80kg: " + rangoAlumnoC + "\n" +
                "Alumnos mayor de 80kg: " + rangoAlumnoC + " alumnos" + "\n" +
                "Porcentaje hasta 50kg: " + porcentajeA + "%" + "\n" +
                "Porcentaje entre 50kg y 65kg: " + porcentajeA + "%" + "\n" +
                "Porcentaje entre 65kg y 80kg: " + porcentajeA + "%" + "\n"+
                "Porcentaje mayor 80kg: " + porcentajeA + "%" + "\n" +
                "Peso medio alumnos: " + pesoMedio + "kg");
        }
    }
}
