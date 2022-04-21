using API_Utilitary.Data;
using API_Utilitary.Modelos;
using API_Utilitary.Servicios;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_Utilitary.Controllers
{
    /// <summary> 
    /// 
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class EjemploController : ControllerBase
    {
        private readonly AplicationContext _dbcontext;
        private readonly IProceduresEjemplo _proceduresEjemplo;
        public EjemploController(AplicationContext dbcontext, IProceduresEjemplo proceduresEjemplo)
        {
            _dbcontext = dbcontext;
            _proceduresEjemplo = proceduresEjemplo;
        }

        /// <summary>
        /// Crea un Autor
        /// </summary>
        /// <param code="200">Crea un Autor </param>
        /// <returns></returns>        
        [HttpPost(nameof(PöstAutores))]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IEnumerable<string>> PöstAutores([FromBody] AutorModels parametros)
        {
            return await _proceduresEjemplo.PöstAutores(parametros);
        }

        /// <summary>
        /// Crea un Libro
        /// </summary>
        /// <param code="200">Crea un Libro </param>
        /// <returns></returns>        
        [HttpPost(nameof(PöstLibros))]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IEnumerable<string>> PöstLibros([FromBody] LibrosModel parametros)
        {
            return await _proceduresEjemplo.PöstLibros(parametros);
        }
    }
}
