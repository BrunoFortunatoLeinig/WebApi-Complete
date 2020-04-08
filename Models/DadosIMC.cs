using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace Exercícios.Models
{
    public class DadosIMC
    {
        public int ID { get; set; }

        public string Nome { get; set; }

        [DataType(DataType.Date)]
        public DateTime DataNascimento { get; set; }

        public decimal Massa { get; set; }

        public string Altura { get; set; }

        public decimal IMC { get; set; }
    }
}
