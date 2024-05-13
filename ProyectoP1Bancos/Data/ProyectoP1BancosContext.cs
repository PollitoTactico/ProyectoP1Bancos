using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProyectoP1Bancos.Models;

namespace ProyectoP1Bancos.Data
{
    public class ProyectoP1BancosContext : DbContext
    {
        public ProyectoP1BancosContext (DbContextOptions<ProyectoP1BancosContext> options)
            : base(options)
        {
        }

        public DbSet<ProyectoP1Bancos.Models.ObjetoDes> ObjetoDes { get; set; } = default!;
        public DbSet<ProyectoP1Bancos.Models.Usuario> Usuario { get; set; } = default!;
        public DbSet<ProyectoP1Bancos.Models.Cuenta> Cuenta { get; set; } = default!;
        public DbSet<ProyectoP1Bancos.Models.RegistroUsuario> RegistroUsuario { get; set; } = default!;
        public DbSet<ProyectoP1Bancos.Models.Meta> Meta { get; set; } = default!;
    }
}
