using System;
using TPFinal.Domain;
using System.Collections.Generic;
using TPFinal.DAL.EntityFramework;

namespace TPFinal.DAL
{
    interface IRepositorioPrestamos : IRepositorio<Prestamo>
    {
        List<Prestamo> GetPrestamosActivos();
        Prestamo GetPrestamo(UsuarioSimple pUsuario);
    }
}