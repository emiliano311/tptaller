using System.ComponentModel.DataAnnotations;

namespace TPFinal.Domain
{
    public class Editorial
    {
        [Key]
        private string iNombre;
        private string iDireccion;
        private int iTelefono;
        private int iIdEditorial;
        public Editorial (string pNombre, string pDireccion, int pTelefono, int pIdEditorial)
        {
            iNombre = pNombre;
            iDireccion = pDireccion;
            iTelefono = pTelefono;
            iIdEditorial = pIdEditorial;
        }
        public string Nombre
        {
            get {return this.iNombre;}
            set{this.iNombre = value;}
        }
        public string Direccion
        {
            get {return this.iDireccion;}
            set{this.iDireccion = value;}
        }
        public int Telefono
        {
            get {return this.iTelefono;}
            set{this.iTelefono = value;}
        }
        public int IdEditorial
        {
            get {return this.iIdEditorial;}
            set{this.iIdEditorial = value;}
        }
    }
}