using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Exercícios.Models;

namespace Exercícios.Data
{
    public class ExercíciosContext : DbContext
    {
        public ExercíciosContext (DbContextOptions<ExercíciosContext> options)
            : base(options)
        {
        }

        public DbSet<Exercícios.Models.DadosIMC> DadosIMC { get; set; }
    }
}
