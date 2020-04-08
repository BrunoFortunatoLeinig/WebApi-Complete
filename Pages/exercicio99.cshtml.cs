using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Exercícios.Pages
{
    public class Exercicio99Model : PageModel
    {
        private readonly ILogger<Exercicio99Model> _logger;

        public string Frase { get; set; }
        public string FraseNova { get; set; }

        public Exercicio99Model(ILogger<Exercicio99Model> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }

        public void OnPost()
        {
            var Frase = Request.Form["Frase"];
            var FraseNova = "";

            for (int i = 0; i < Frase.ToString().Length; i++)
            {
                var FraseAux = Frase.ToString().ToCharArray();
                if (FraseAux[i] == 'A' || FraseAux[i] == 'a')
                {
                    FraseNova += "&";
                }
                else
                {
                    FraseNova += FraseAux[i];
                }
            }

            this.Frase = ("Você Escreveu: " + Frase);
            this.FraseNova = ("Foi Alterado para: " + FraseNova);
        }
    }
}
