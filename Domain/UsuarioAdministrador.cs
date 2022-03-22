namespace TPFinal.Domain
{
    public class UsuarioAdministrador //Controlador
    {
        private string iNombreUsuario;
        private string iContrasena;
        public UsuarioAdministrador(string pNombreUsuario, string pContrasena)
        {
            iNombreUsuario = pNombreUsuario;
            iContrasena = pContrasena;
        }
        public string NombreUsuario 
        {
            get {return this.iNombreUsuario;}
            set {this.iNombreUsuario = value;}
        }
        public string Contrasena 
        {
            get {return this.iContrasena;}
            set {this.iContrasena = value;}
        }
    }
}