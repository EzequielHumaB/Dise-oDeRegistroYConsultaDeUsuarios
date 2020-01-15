using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RegistroUsuarios.Models;

namespace RegistroUsuarios.Data
{
    public class RegistroUsuariosContext : DbContext
    {
        public RegistroUsuariosContext (DbContextOptions<RegistroUsuariosContext> options)
            : base(options)
        {
        }

        public DbSet<RegistroUsuarios.Models.Categoria> Categoria { get; set; }
    }
}
