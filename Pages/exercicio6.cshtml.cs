using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Exercícios.Pages
{
    public class Exercicio6Model : PageModel
    {
        private readonly ILogger<Exercicio6Model> _logger;

        public string Salario { get; set; }

        public Exercicio6Model(ILogger<Exercicio6Model> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }

        public void OnPost()
        {
            var Salario = Request.Form["Salario"];
            double SalarioAux = Double.Parse(Salario);
            if (SalarioAux < 1700)
            {
                this.Salario = ("Seu aumento é de R$300,00 Ficando em : R$" + ((int.Parse(Salario) + 300))).ToString();
            }
            else
            {
                this.Salario = ("Seu aumento é de R$200,00 Ficando em : R$" + ((int.Parse(Salario) + 200))).ToString();
            }
        }
    }
}
