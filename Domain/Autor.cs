namespace TPFinal.Domain
{
    public class Autor
    {
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