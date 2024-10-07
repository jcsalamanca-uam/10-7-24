using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace _10_7_24
{
    internal class Calculadora
    {
        public double Suma(double num1, double num2)
        {
            return num1 + num2;
        }

        public double Resta(double num1, double num2)
        {
            return num1 - num2;
        }
        public double Multiplicacion(double num1, double num2)
        {
            return num1 * num2;
        }
        public double Division(double num1, double num2)
        {
            try
            {
                if (num1 == 0 || num2 == 0)
                {
                    Console.WriteLine("ERROR: NO SE PUEDE DIVIDIR ENTRE 0");
                    return 0;
                }
                else
                {
                    return num1 / num2;

                }
                }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
        }

        public double Potencia(double num1, double num2)
        {
            return Math.Pow(num1, num2);
        }

        public double Raiz(double num1, double num2)
        {
            return Math.Pow(num1, 1.0 / num2);
        }




    }
}
