namespace TPFinal.Domain
{
    public class UsuarioSimple
    {
        private int iNumeroUsuario;
        private string iNombre;
        private string iDireccion;
        private int iTelefono;
        private int iDocumento;
        private int iPuntaje;
        private string iMail;

        public UsuarioSimple() { }
        public UsuarioSimple (int pNumeroUsuario, string pNombre, string pDireccion, int pTelefono, int pDocumento, int pPuntaje, string pMail)
        {
            iNumeroUsuario = pNumeroUsuario;
            iNombre = pNombre;
            iDireccion = pDireccion;
            iTelefono = pTelefono;
            iDocumento = pDocumento;
            iPuntaje = pPuntaje;
            iMail = pMail;
        }
        public int NumeroUsuario 
        {
            get {return this.iNumeroUsuario;}
            set {this.iNumeroUsuario = value;}
        }
        public string Nombre 
        {
            get {return this.iNombre;}
            set {this.iNombre = value;}
        }
        public string Direccion 
        {
            get {return this.iDireccion;}
            set {this.iDireccion = value;}
        }
        public int Telefono 
        {
            get {return this.iTelefono;}
            set {this.iTelefono = value;}
        }
        public int Documento 
        {
            get {return this.iDocumento;}
            set {this.iDocumento = value;}
        }
        public int Puntaje
        {
            get {return this.iPuntaje;}
            set {this.iPuntaje = value;}
        }
        public string Mail 
        {
            get {return this.iMail;}
            set {this.iMail = value;}
        }
    }
}