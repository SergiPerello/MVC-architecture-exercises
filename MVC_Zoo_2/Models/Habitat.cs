using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Zoo_2.Models
{
    public class Habitat
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Clima { get; set; }
        public string Vegetacion { get; set; }
        public int ItinerarioId { get; set; }
        public Itinerario Itinerario { get; set; }
        public ICollection<HabitatEspecie> HabitatEspecie { get; set; }
    }
}
