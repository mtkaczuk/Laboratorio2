using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class GuardaString
    {
        #region Métodos
        public static bool Guardar(this string texto, string archivo)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(archivo, true))
                {
                    sw.WriteLine(texto);
                }

                return true;
            }

            catch (Exception)
            {
                return false;
            }
        }
        #endregion
    }
}