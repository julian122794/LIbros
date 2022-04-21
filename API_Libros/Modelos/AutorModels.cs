using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_Utilitary.Modelos
{
    public class AutorModels
    {
        public int IdAutor { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string? CiudadProcedencia { get; set; }
        public string CorreoElectronico { get; set; }

    }
}
