using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Exercícios.Pages
{
    public class Exercicio5Model : PageModel
    {
        private readonly ILogger<Exercicio5Model> _logger;

        public string Dados { get; set; }

        public Exercicio5Model(ILogger<Exercicio5Model> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
        public void OnPost()
        {
            var Dados1 = Request.Form["Dados1"];
            var Dados2 = Request.Form["Dados2"];
            var Dados3 = Request.Form["Dados3"];
            var Dados4 = Request.Form["Dados4"];
            this.Dados = ("Os dados informados são: " + Dados1 + " / " + Dados2 + " / " + Dados3 + " / " + Dados4);
        }
    }
}
