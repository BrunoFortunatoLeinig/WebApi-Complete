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
    public class Exercicio9Model : PageModel
    {
        private readonly ILogger<Exercicio9Model> _logger;

        public string IMC { get; set; }
        public string Cadastro { get; set; }

        public Exercicio9Model(ILogger<Exercicio9Model> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }

        public void OnPost()
        {
            var M = Request.Form["M"];
            var A = Request.Form["A"];
            IMC = ((double.Parse(M)) / (double.Parse(A) * double.Parse(A))).ToString();
            if ((double.Parse(IMC) >= 18.25) && (double.Parse(IMC) < 25))
            {
                this.IMC = string.Format("Seu IMC é: {0: 0.00} você está no peso ideal", Convert.ToDouble(IMC));
            }
            else
            {
                this.IMC = string.Format("Seu IMC é: {0: 0.00} você está acima do peso ideal", Convert.ToDouble(IMC));
            }
        }
    }
}
