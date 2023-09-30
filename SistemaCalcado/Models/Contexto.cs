using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace SistemaCalcado.Models
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {
        }

        public DbSet<Calcado> Calcados { get; set; }

    }
}
