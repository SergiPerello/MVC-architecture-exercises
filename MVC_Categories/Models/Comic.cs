using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Categories.Models
{
    public class Comic
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public DateTime Fecha { get; set; }

        public int CategoriaId { get; set; }
        public Categoria Categoria { get; set; }
        public ICollection<ComicAutor> ComicAutor { get; set; }
    }
}
