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
    public class DetailsModel : PageModel
    {
        private readonly Exercícios.Data.ExercíciosContext _context;

        public DetailsModel(Exercícios.Data.ExercíciosContext context)
        {
            _context = context;
        }

        public DadosIMC DadosIMC { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            DadosIMC = await _context.DadosIMC.FirstOrDefaultAsync(m => m.ID == id);

            if (DadosIMC == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
