using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVC_Zoo_2.Models;

namespace MVC_Zoo_2.Models
{
    public class MVC_Zoo_2Context : DbContext
    {
        public MVC_Zoo_2Context (DbContextOptions<MVC_Zoo_2Context> options)
            : base(options)
        {
        }

        public DbSet<MVC_Zoo_2.Models.Especie> Especie { get; set; }

        public DbSet<MVC_Zoo_2.Models.Habitat> Habitat { get; set; }

        public DbSet<MVC_Zoo_2.Models.Itinerario> Itinerario { get; set; }
    }
}
