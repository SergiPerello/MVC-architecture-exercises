using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Zoo.Models
{
    public class Itinerario
    {
        public int Id { get; set; }
        public string codigo { get; set; }
        public int duracion { get; set; }
        public int visitantes { get; set; }
        public int longitud { get; set; }
        public ICollection<Habitat> habitats { get; set; }
    }
}
