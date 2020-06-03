using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Zoo.Models
{
    public class Especie
    {
        public int Id { get; set; }
        public string nombre_com { get; set; }
        public string nombre_cient { get; set; }
        public string descripcion { get; set; }
        public string foto { get; set; }
        public ICollection<HabitatEspecie> habitatEspecies { get; set; }
    }
}
