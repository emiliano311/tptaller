using System;
using System.ComponentModel.DataAnnotations;

namespace TPFinal.Domain
{
    public class Ejemplar
    {
        [Key]
        private int iCodigoInventario;
        private int iCodigoUbicacion;
        private DateTime iFechaAlta;
        private bool iPrestado;
        public Ejemplar(int pCodigoInventario, int pCodigoUbicacion, DateTime pFechaAlta)
        {
            iCodigoInventario = pCodigoInventario;
            iCodigoUbicacion = pCodigoUbicacion;
            iFechaAlta = pFechaAlta;
            iPrestado = false;
        }
        public int CodigoInventario 
        {
            get {return this.iCodigoInventario;}
            set {this.iCodigoInventario =  value;}
        }
        public int CodigoUbicacion
        {
            get {return this.iCodigoUbicacion;}
            set {this.iCodigoUbicacion =  value;}
        }
        public DateTime FechaAlta
        {
            get {return this.iFechaAlta;}
            set {this.iFechaAlta =  value;}
        }
        public bool Prestado 
        {
            get {return this.iPrestado;}
            set {this.iPrestado = value;}
        }
    }
}