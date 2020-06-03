using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVC_Comics.Models;

namespace MVC_Comics.Models
{
    public class MVC_ComicsContext : DbContext
    {
        public MVC_ComicsContext (DbContextOptions<MVC_ComicsContext> options)
            : base(options)
        {
        }

        public DbSet<MVC_Comics.Models.Autor> Autor { get; set; }

        public DbSet<MVC_Comics.Models.Categoria> Categoria { get; set; }

        public DbSet<MVC_Comics.Models.Comic> Comic { get; set; }
    }
}
