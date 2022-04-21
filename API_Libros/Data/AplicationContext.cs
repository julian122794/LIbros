using API_Utilitary.Modelos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_Utilitary.Data
{
    public class AplicationContext : DbContext
    {
        public AplicationContext(DbContextOptions<AplicationContext> option) : base(option)
        {

        }
    }
}
