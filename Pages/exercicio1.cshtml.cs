using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Exercícios.Pages
{
    public class Exercicio1Model : PageModel
    {
        private readonly ILogger<Exercicio1Model> _logger;
        public string Text { get; set; }


        public Exercicio1Model(ILogger<Exercicio1Model> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
        public void OnPost()
        {
            var Nome1 = Request.Form["Nome"];
            this.Text = ("Seja Bem Vindo!!! " + Nome1);
        }
    }

}
