using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Calculadora
    {
        #region Métodos
        public static double Operar(Numero num1, Numero num2, string operador)
        {
            string opValido;
            double ret;
            opValido = ValidarOperador(operador);
            switch (opValido)
            {
                case "+":
                    ret = num1 + num2;
                    break;
                case "-":
                    ret = num1 - num2;
                    break;
                case "*":
                    ret = num1 * num2;
                    break;
                case "/":
                    ret = num1 / num2;
                    break;
                default:
                    ret = num1 + num2;
                    break;
            }
            return ret;
        }
        private static string ValidarOperador(string operador)
        {
            if (operador != "+" && operador != "-" && operador != "*" && operador != "/")
                operador = "+";
            return operador;
        }
        #endregion
    }
}
