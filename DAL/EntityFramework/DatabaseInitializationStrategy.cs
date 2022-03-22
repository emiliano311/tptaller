using TPFinal.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace TPFinal.DAL.EntityFramework
{
    public class DatabaseInitializationStrategy : CreateDatabaseIfNotExists<ManagerPrestamosDbContext>
    {
        //Hay que ver que se inicializa acá porque los libros no debería pero nose usuarios y demás




    }
}