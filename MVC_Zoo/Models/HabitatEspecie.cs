using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Zoo.Models
{
    public class HabitatEspecie
    {
        public int Id { get; set; }
        public int habitatId { get; set; }
        public Habitat habitat { get; set; }
        public int especieId { get; set; }
        public Especie especie { get; set; }
        public int indice { get; set; }
    }
}
