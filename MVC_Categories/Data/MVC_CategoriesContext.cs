using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVC_Categories.Models;

namespace MVC_Categories.Models
{
    public class MVC_CategoriesContext : DbContext
    {
        public MVC_CategoriesContext (DbContextOptions<MVC_CategoriesContext> options)
            : base(options)
        {
        }

        public DbSet<MVC_Categories.Models.Categoria> Categoria { get; set; }

        public DbSet<MVC_Categories.Models.Autor> Autor { get; set; }

        public DbSet<MVC_Categories.Models.Comic> Comic { get; set; }
    }
}
