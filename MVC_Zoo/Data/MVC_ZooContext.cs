using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVC_Zoo.Models;

namespace MVC_Zoo.Models
{
    public class MVC_ZooContext : DbContext
    {
        public MVC_ZooContext (DbContextOptions<MVC_ZooContext> options)
            : base(options)
        {
        }

        public DbSet<MVC_Zoo.Models.Especie> Especie { get; set; }

        public DbSet<MVC_Zoo.Models.Habitat> Habitat { get; set; }

        public DbSet<MVC_Zoo.Models.Itinerario> Itinerario { get; set; }
    }
}
