using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System.ComponentModel;

namespace Exercícios.Pages
{
    public class Exercicio7Model : PageModel
    {
        private readonly ILogger<Exercicio7Model> _logger;

        public string Acesso { get; set; }
        public bool IsRed { get; set; }


        public Exercicio7Model(ILogger<Exercicio7Model> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }

        public void OnPost()
        {
            var Acesso = Request.Form["Acesso"];
            double ID = double.Parse(Acesso);
            ID = ((DateTime.Now.Year) - (double.Parse(Acesso)));
            if (ID >= 18)
            {
                this.Acesso = ("Acesso Permitido");
            }
            else
            {
                IsRed = true;
                this.Acesso = ("Acesso Negado");
            }
        }
    }
}
