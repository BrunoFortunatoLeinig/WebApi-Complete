using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Exercícios.Data;
using Exercícios.Models;

namespace Exercícios.Pages.Exer9
{
    public class IndexModel : PageModel
    {
        private readonly Exercícios.Data.ExercíciosContext _context;

        public IndexModel(Exercícios.Data.ExercíciosContext context)
        {
            _context = context;
        }

        public IList<DadosIMC> DadosIMC { get;set; }

        public async Task OnGetAsync()
        {
            DadosIMC = await _context.DadosIMC.ToListAsync();
        }
    }
}
