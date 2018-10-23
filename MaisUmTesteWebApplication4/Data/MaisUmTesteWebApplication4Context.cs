using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MaisUmTesteWebApplication4.Data;

namespace MaisUmTesteWebApplication4.Models
{
    public class MaisUmTesteWebApplication4Context : DbContext
    {
        public MaisUmTesteWebApplication4Context (DbContextOptions<MaisUmTesteWebApplication4Context> options)
            : base(options)
        {
        }

        public DbSet<MaisUmTesteWebApplication4.Data.Usuario> Usuario { get; set; }
    }
}
