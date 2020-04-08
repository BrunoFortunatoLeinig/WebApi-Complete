using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System.Drawing;

namespace Exercícios.Pages
{
    public class Exercicio91Model : PageModel
    {
        private readonly ILogger<Exercicio91Model> _logger;

        public string IMC2 { get; set; }
        public string Cadastro { get; set; }

        public Exercicio91Model(ILogger<Exercicio91Model> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }

        public void OnPost()
        {
            var N = Request.Form["N"];
            var ID = Request.Form["ID"];
            var M = Request.Form["M"];
            var A = Request.Form["A"];
            IMC2 = ((double.Parse(M)) / (double.Parse(A) * double.Parse(A))).ToString();
            if ((double.Parse(IMC2) >= 18.25) && (double.Parse(IMC2) < 25))
            {
                this.IMC2 = string.Format("{0} de {1} Anos Seu IMC é: {2: 0.00} você está no peso ideal", N, ID, Convert.ToDouble(IMC2));
            }
            else
            {
                this.IMC2 = string.Format("{0} de {1} Anos Seu IMC é: {2: 0.00} você está acima do peso ideal", N, ID, Convert.ToDouble(IMC2));
            }
        }
    }
}
