using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Exercícios.Pages
{
    public class Exercicio2e3Model : PageModel
    {
        private readonly ILogger<Exercicio2e3Model> _logger;
        public string Soma { get; set; }

        public Exercicio2e3Model(ILogger<Exercicio2e3Model> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
        public void OnPost()
        {
            var N1 = Request.Form["N1"];
            var N2 = Request.Form["N2"];

            this.Soma = ("A soma entre os números é: " + (int.Parse(N1) + int.Parse(N2))).ToString();
        }
    }
}
