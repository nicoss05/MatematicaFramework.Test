using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatematicaFramework.Test
{
    class Calculadora
    {
        public int AumentarEnteros(int numeroEntero1, int numeroEntero2)
        {
            var suma = numeroEntero1;
            for (var i = 0; i < numeroEntero2; i++)
            {
                suma++;
            }
            return suma;
        }

        internal double RaizCuadrada(double numero1)
        {
            if (numero1 < 0)
                throw new ArgumentException("No se puede recibir numeros negativos");
            return Math.Sqrt(numero1);
            
        }

        public string longNombres(string nombre, string apellidoPaterno, string apellidoMaterno)
        {
            int total;
            string result;
            total = nombre.Length + apellidoPaterno.Length + apellidoMaterno.Length;
            if (total > 50)
            {
                result = "Nombre demasiado largo";
            }
            else
            {
                result = "Admitido";
            }
            return result;
        }
    }
}
