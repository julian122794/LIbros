using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_Utilitary.Modelos
{
    public class LibrosModel
    {
        public int IdLibro { get; set; }
        public int AutorId { get; set; }
        public string? Titulo { get; set; }
        public DateTime Anio { get; set; }
        public string? Genero { get; set; }
        public string? NumeroPaginas { get; set; }
    }
}
