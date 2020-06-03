using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Zoo.Models
{
    public class Habitat
    {
        public int Id { get; set; }
        public string nombre { get; set; }
        public string clima { get; set; }
        public string vegetacion { get; set; }
        public int itinerarioId { get; set; }
        public Itinerario itinerario { get; set; }
        public ICollection<HabitatEspecie> habitatEspecies { get;set; }

    }
}
