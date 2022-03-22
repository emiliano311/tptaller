using System;
namespace TPFinal.Domain
{
    public class Prestamo
    {
        private int iIdPrestamo;
        private DateTime iFechaInicio;
        private DateTime iFechaFin;
        private DateTime iFechaVencimiento;
        public Prestamo (int pIdPrestamo, DateTime pFechaFin, DateTime pFechaVencimiento)
        {
            iIdPrestamo = pIdPrestamo;
            iFechaInicio = DateTime.Now;
            iFechaFin = pFechaFin;
            iFechaVencimiento = pFechaVencimiento;
        }
        public int IdPrestamo 
        {
            get {return this.iIdPrestamo;}
            set {this.iIdPrestamo = value;}
        }
        public DateTime FechaInicio 
        {
            get {return this.iFechaInicio;}
            set {this.iFechaInicio = value;}
        }
        public DateTime FechaFin 
        {
            get {return this.iFechaFin;}
            set {this.iFechaFin = value;}
        }
        public DateTime FechaVencimiento 
        {
            get {return this.iFechaVencimiento;}
            set {this.iFechaVencimiento = value;}
        }
    }
}