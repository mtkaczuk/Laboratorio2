using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Numero
    {
        #region Variables
        private double _numero;
        #endregion

        #region Propiedades
        public string SetNumero
        { 
            set
            {
                this._numero = ValidarNumero(value);
            }
        }
        #endregion

        #region Constructores
        public Numero()
        {
            this._numero = 0;
        }
        public Numero(double numero)
            : this()
        {
            this._numero = numero;
        }
        public Numero(string numero)
            : this()
        {
            this._numero = double.Parse(numero);
        }
        #endregion

        #region Métodos
        private double ValidarNumero(string strNumero)
        {
            double retorno;
            if (!double.TryParse(strNumero, out retorno))
                retorno = 0;
            return retorno;
        }
        public string BinarioDecimal(string binario)
        {
            if (binario == "0")
            {
                return "0";
            }           
            
            int exp = binario.Length - 1;
            int num_decimal = 0;
            string numDec = "";

            for (int i = 0; i < binario.Length; i++)
            {
                if (int.Parse(binario.Substring(i, 1)) == 1)
                {
                    num_decimal = num_decimal + int.Parse(System.Math.Pow(2, double.Parse(exp.ToString())).ToString());
                }
                exp--;
            }
            return numDec = num_decimal.ToString();
        }
        public string DecimalBinario(double numero)
        {
            if (numero == 0)
            {
                return "0";
            }
            
            string cadena = "";
            if (numero > 0)
            {
                while (numero > 0)
                {
                    if (numero % 2 == 0)
                    {
                        cadena = "0" + cadena;
                    }
                    else
                    {
                        cadena = "1" + cadena;
                    }
                    numero = (int)(numero / 2);
                }
            }
            else
            {
                return "Valor inválido";
            }
            return cadena;
        }
        public string DecimalBinario(string numero)
        {
            double num = Convert.ToDouble(numero);
            return DecimalBinario(num);
        }
        #region Operaciones
        public static double operator +(Numero num1, Numero num2)
        {
            double rdo;
            rdo = num1._numero + num2._numero;
            return rdo;
        }
        public static double operator -(Numero num1, Numero num2)
        {
            double rdo;
            rdo = num1._numero - num2._numero;
            return rdo;
        }
        public static double operator *(Numero num1, Numero num2)
        {
            double rdo;
            rdo = num1._numero * num2._numero;
            return rdo;
        }
        public static double operator /(Numero num1, Numero num2)
        {
            double rdo;
            if (num2._numero == 0)
            {
                rdo = 0;
            }
            else
	        {
                rdo = num1._numero / num2._numero;     
	        }            
            return rdo;
        }
        #endregion
        #endregion
    }
}
