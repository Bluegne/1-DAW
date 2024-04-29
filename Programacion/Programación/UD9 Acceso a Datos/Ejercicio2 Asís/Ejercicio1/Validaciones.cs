using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Ejercicio1
{
    static class Validaciones
    {
        public static bool ComprobarTlf(string tlf)
        {
            bool validado = false;
            if (tlf.Length == 9)
            {
                validado = true;
                for (int i = 0; i < tlf.Length; i++)
                {
                    if (char.IsLetter(tlf[i]))
                    {
                        validado = false;
                    }
                }
            }
            return validado;
        }
        public static bool ComprobarNombre(string nombre)
        {
            bool validado = false;
            if (nombre != "")
            {
                validado = true;
                for (int i = 0; i < nombre.Length; i++)
                {
                    if (!char.IsLetter(nombre[i]))
                    {
                        validado = false;
                    }
                }
            }
            return validado;
        }
        public static bool ComprobarDni(string dni)
        {
            bool validado = false;
            if (dni.Length == 9 && char.IsLetter(dni[8]))
            {
                validado = true;
                for (int i = 0; i < dni.Length - 1; i++)
                {
                    if (char.IsLetter(dni[i]))
                    {
                        validado = false;
                    }
                }
            }
            return validado;
        }
        public static bool ComprobarEmail(string email)
        {
            bool validado = false;
            string modelo = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            Regex regexmail = new Regex(modelo);
            if (regexmail.IsMatch(email))
            {
                validado = true;
            }
            return validado;
        }
    }
}
