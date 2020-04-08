using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Exercícios.Pages
{
    public class PaginaInicialModel : PageModel
    {
        private readonly ILogger<PaginaInicialModel> _logger;

        public PaginaInicialModel(ILogger<PaginaInicialModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}
