using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Categories.Models
{
    public class Autor
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Nacionalidad { get; set; }
        public int AnyNacimiento { get; set; }
        public ICollection<ComicAutor> ComicAutor { get; set; }
    }
}
