using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace TPFinal.Domain
{
    public class Libro
    {
        [Key]
        private int iISBN;
        private string iTitulo;
        private DateTime iFechaPublicacion;
        private int iCantidadPaginas;
        public Editorial Editorial { get; set; }

        public virtual ICollection<Ejemplar> Ejemplar { get; set; }
        public virtual ICollection<LibroAutor> LibroAutor { get; set; }
        public virtual ICollection<LibroCategoria> LibroCategoria { get; set; }
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