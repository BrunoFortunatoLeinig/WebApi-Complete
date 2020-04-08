using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Exercícios.Pages
{
    public class Exercicio8Model : PageModel
    {
        private readonly ILogger<Exercicio8Model> _logger;
        public string Calc { get; set; }

        public Exercicio8Model(ILogger<Exercicio8Model> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }

        public void OnPost()
        {
            var N5 = Request.Form["N5"];
            var N6 = Request.Form["N6"];
            var OP = Request.Form["OP"];

            if (OP == "+")
            {
                this.Calc = ("A soma entre os números é: " + (int.Parse(N5) + int.Parse(N6))).ToString();
            }
            if (OP == "-")
            {
                this.Calc = ("A Subtração entre os números é: " + (int.Parse(N5) - int.Parse(N6))).ToString();
            }
            if (OP == "*")
            {
                this.Calc = ("A Multiplicação entre os números é: " + (int.Parse(N5) * int.Parse(N6))).ToString();
            }
            if (OP == "/")
            {
                this.Calc = ("A soma entre os números é: " + (int.Parse(N5) / int.Parse(N6))).ToString();
            }
        }
    }
}
