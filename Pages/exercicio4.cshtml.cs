using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Primitives;

namespace Exercícios.Pages
{
    public class Exercicio4Model : PageModel
    {
        private readonly ILogger<Exercicio4Model> _logger;

        public string Impar { get; set; }

        public Exercicio4Model(ILogger<Exercicio4Model> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }

        public void OnPost()
        {
            var N3 = Request.Form["N3"];
            double naux = double.Parse(N3);
            if (naux % 2 == 0)
            {
                this.Impar = ("Este número é PAR!!! ");
            }
            else
            {
                this.Impar = ("Este número é IMPAR!!!");
            }
        }
    }
}
