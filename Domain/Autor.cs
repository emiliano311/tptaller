using System.ComponentModel.DataAnnotations;

namespace TPFinal.Domain
{
    public class Autor
    {   
        [Key]
        public int Id { get; set; }
        private string iNombre;
        private int iIdAutor;
        public Autor(string pNombre, int pIdAutor)
        {
            iNombre = pNombre;
            iIdAutor = pIdAutor;
        }
        public string Nombre
        {
            get {return this.iNombre;}
            set{this.iNombre = value;}
        }
        public int IdAutor
        {
            get {return this.iIdAutor;}
            set{this.iIdAutor = value;}
        }
    }
}