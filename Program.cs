using System;
using TPFinal.DAL.EntityFramework;
using TPFinal.Domain;

namespace TPFinal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            UsuarioSimple usuarioSimple = new UsuarioSimple();
           // usuarioSimple.NumeroUsuario = 24;
            usuarioSimple.Nombre = "Juan";
            usuarioSimple.Puntaje = 1;
            usuarioSimple.Direccion = "";
            usuarioSimple.Telefono = 1234;
            usuarioSimple.Documento = 333334;
            usuarioSimple.Mail = "asd@asdcom";
            ManagerPrestamosDbContext db = new ManagerPrestamosDbContext();
            RepositorioUsuario repositorioUsuario = new RepositorioUsuario(db);
            try
            {
                db.usuarios.Add(usuarioSimple);
                db.SaveChanges();
            }
            catch (System.Data.Entity.Core.EntityException e) {   
                Console.WriteLine(e);
             }

        }
    }
}
