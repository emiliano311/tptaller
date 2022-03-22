namespace TPFinal.Domain
{
    public class Categoria
    {
        private string iNombre;
        private int iIdCategoria;
        public Categoria(string pNombre, int pIdCategoria)
        {
            iNombre = pNombre;
            iIdCategoria = pIdCategoria;
        }
        public string Nombre
        {
            get {return this.iNombre;}
            set{this.iNombre = value;}
        }
        public int IdCategoria
        {
            get {return this.iIdCategoria;}
            set{this.iIdCategoria = value;}
        }
    }
}