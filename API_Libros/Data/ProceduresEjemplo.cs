using API_Utilitary.Modelos;
using API_Utilitary.Servicios;
using Dapper;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace API_Utilitary.Data
{
    public class ProceduresEjemplo : IProceduresEjemplo
    {      

        private readonly IConfiguration _configuration;
        public ProceduresEjemplo(IConfiguration configuration)
        {
            _configuration = configuration;
        } 

        public async Task<IEnumerable<string>> PöstAutores(AutorModels autor)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@NombreCompleto", autor.Nombre);
            parameters.Add("@FechaNacimiento", autor.FechaNacimiento);
            parameters.Add("@CiudadProcedencia", autor.CiudadProcedencia);
            parameters.Add("@CorreoElectronico", autor.CorreoElectronico);
            using IDbConnection db = new SqlConnection(_configuration.GetConnectionString("DefaultConnection"));
            string sp = "[dbo].[USP_REGISTRAR_AUTOR]";
            var result = await Task.FromResult(db.Query<string>(sp, parameters, commandType: CommandType.StoredProcedure).ToList());
            return result;
        }   

        public async  Task<IEnumerable<string>> PöstLibros(LibrosModel libros)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@Titulo", libros.Titulo);
            parameters.Add("@Anio", libros.Anio);
            parameters.Add("@Genero", libros.Genero);
            parameters.Add("@NumeroPaginas", libros.NumeroPaginas);
            parameters.Add("@AutorId", libros.AutorId);
            using IDbConnection db = new SqlConnection(_configuration.GetConnectionString("DefaultConnection"));
            string sp = "[dbo].[USP_REGISTRAR]";
            var result = await Task.FromResult(db.Query<string>(sp, parameters, commandType: CommandType.StoredProcedure).ToList());
            return result;
        }

    }
}
