﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Ejercicio_2
{
    public abstract class Figura
    {
        //TODO miembros
        private double mPosicionX;
        private double mPosicionY;
        private string mColor;

        //TODO propiedades
        public double PosicionX
        {
            get { return mPosicionX; }
            set { mPosicionX = value; }
        }

        public double PosicionY
        {
            get { return mPosicionY; }
            set { mPosicionY = value;}
        }

        public string Color
        {
            get { return mColor; }
            set { mColor = value; }
        }
        
        //TODO constructor
        public Figura(double x, double y, string color) 
        {
            mPosicionX = x;
            mPosicionY = y;
            mColor = color;
        }

        //TODO Método virtual QuienSoy. Se puede reescribir en las clases que heredan
        public virtual string QuienSoy()
        {
            return "Soy una figura";
        }

        //TODO Sobreescritura del método ToString que heredamos de System.Object
        public override string ToString()
        {
            string texto;
            texto = "Posicion X: " + mPosicionX + "\nPosicion Y: " + mPosicionY + "\nColor: " + mColor;

            return texto;
        }

        //TODO Método abstracto Area. No tiene cuerpo.
        //Se reescribe en las clases que heredan de Figura
        public abstract double Area();

        //TODO Método abstracto Perimetro. No tiene cuerpo.
        //Se reescribe en las clases que heredan de Figura
        public abstract double Perimetro();
    }
}
