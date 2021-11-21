using AGMBankingV1.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace AGMBankingV1.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        //Agregar la tabla Empleados
       public DbSet<Empleado> Empleados { get; set; }


        //Conexion con el DbContext
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
