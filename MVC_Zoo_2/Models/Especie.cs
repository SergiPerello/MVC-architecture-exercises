using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Zoo_2.Models
{
    public class Especie
    {
        public int Id { get; set; }
        public string Nombre_com { get; set; }
        public string Nombre_cient { get; set; }
        public string Descripcion { get; set; }
        public string Foto { get; set; }
        public ICollection<HabitatEspecie> HabitatEspecie { get; set; }
    }
}
