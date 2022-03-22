using System;
namespace TPFinal.Domain
{
    public class Libro
    {
        private int iISBN;
        private string iTitulo;
        private DateTime iFechaPublicacion;
        private int iCantidadPaginas;
        public Libro(int pISBN, string pTitulo, DateTime pFechaPublicacion, int pCantidadPaginas)
        {
            iISBN = pISBN;
            iTitulo = pTitulo;
            iFechaPublicacion = pFechaPublicacion;
            iCantidadPaginas = pCantidadPaginas;
        }
        public int ISBN
        {
            get {return this.iISBN;}
            set {this.iISBN = value;}
        }
        public string Titulo 
        {
            get {return this.iTitulo;}
            set {this.iTitulo = value;}
        }
        public DateTime FechaPublicacion
        {
            get {return this.iFechaPublicacion;}
            set {this.iFechaPublicacion = value;}
        }
        public int CantidadPaginas
        {
            get {return this.iCantidadPaginas;}
            set {this.iCantidadPaginas = value;}
        }
    }
}