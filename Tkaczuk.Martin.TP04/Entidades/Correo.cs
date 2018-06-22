using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Entidades
{
    public class Correo : IMostrar<List<Paquete>>
    {
        #region Variables
        private List<Paquete> paquetes;
        private List<Thread> mockPaquetes;
        #endregion

        #region Propiedades
        public List<Paquete> Paquetes 
        {
            get 
            {
                return this.paquetes;
            }
            set
            {
                this.paquetes = value;
            }
        }
        #endregion

        #region Constructores
        public Correo()
        {
            this.paquetes = new List<Paquete>();
            this.mockPaquetes = new List<Thread>();
        }
        #endregion

        #region Sobrecargas
        public static Correo operator +(Correo c, Paquete p)
        {
            foreach (Paquete item in c.Paquetes)
            {
                if (item == p)
                {
                    throw new TrackingIDRepetidoException("El paquete ya está en la lista");
                }
            }

            c.Paquetes.Add(p);
            Thread t = new Thread(p.MockCicloDeVida);
            c.mockPaquetes.Add(t);
            t.Start();
            return c;
        }
        #endregion

        #region Métodos
        public string MostrarDatos(IMostrar<List<Paquete>> elementos)
        {
            List<Paquete> listaPaquetes = (List<Paquete>)((Correo)elementos).paquetes;
            StringBuilder str = new StringBuilder();

            foreach (Paquete mipaquete in listaPaquetes)
            {
                str.AppendLine(string.Format("{0} para {1} ({2})", mipaquete.TrackingID, mipaquete.DireccionEntrega, mipaquete.Estado.ToString()));
            }
            return str.ToString();
        }
        public void FinEntregas()
        {
            foreach (Thread hilo in this.mockPaquetes)
            {
                if ((!Object.ReferenceEquals(hilo, null)) && hilo.IsAlive)
                {
                    hilo.Abort();
                }
            }
        }
        #endregion
    }
}
