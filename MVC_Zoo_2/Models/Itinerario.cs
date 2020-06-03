using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Zoo_2.Models
{
    public class Itinerario
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public int Duracion { get; set; }
        public int Visitantes { get; set; }
        public int Longitud { get; set; }
        public ICollection<Habitat> Habitat { get; set; }
    }
}
