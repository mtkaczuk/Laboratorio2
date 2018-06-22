using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Entidades
{
    public class Paquete : IMostrar<Paquete>
    {
        #region Enumerados
        public enum EEstado { Ingresado, EnViaje, Entregado }
        #endregion

        #region Variables
        private string direccionEntrega;
        private EEstado estado;
        private string trackingID;
        #endregion

        #region Propiedades
        public string DireccionEntrega 
        { 
            get
            {
                return this.direccionEntrega;
            }
            set 
            {
                this.direccionEntrega = value;
            }
        }
        public EEstado Estado
        { 
            get
            {
                return this.estado;
            }
            set 
            {
                this.estado = value;
            }
        }           
        public string TrackingID
        { 
            get
            {
                return this.trackingID;
            }
            set 
            {
                this.trackingID = value;
            }
        }           
        #endregion

        #region Constructores
        public Paquete(string direccionEntrega, string trackingID)
        {
            this.direccionEntrega = direccionEntrega;
            this.TrackingID = trackingID;
        }
        #endregion

        #region Sobrecargas
        public override string ToString()
        {
            return this.MostrarDatos(this);
        }
        public static bool operator ==(Paquete p1, Paquete p2)
        {
            if (p1.trackingID == p2.trackingID)
            {
                return true;
            }
            return false;
        }
        public static bool operator !=(Paquete p1, Paquete p2)
        {
            return !(p1 == p2);
        }
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        #endregion

        #region Implementación Interfaz
        public string MostrarDatos(IMostrar<Paquete> elemento)
        {
            if (elemento is Paquete)
            {
                Paquete paquete1 = (Paquete)elemento;

                return string.Format("{0} para {1}", paquete1.trackingID, paquete1.direccionEntrega);
            }
            else
            {
                return "";
            }
        }
        #endregion

        #region Hilos
        public delegate void DelegadoEstado(object sender, EventArgs e);
        public event DelegadoEstado InformaEstado;
        public void MockCicloDeVida()
        {
            while (this.Estado != EEstado.Entregado)
            {
                Thread.Sleep(1000);

                if (this.Estado == EEstado.Ingresado)
                    this.Estado = EEstado.EnViaje;
                else if (this.Estado == EEstado.EnViaje)
                    this.Estado = EEstado.Entregado;

                InformaEstado.Invoke(this, new EventArgs());
            }

            try
            {
                PaqueteDAO.Insertar(this);
            }
            catch (Exception)
            {
            }
        }
        #endregion
    }
}
