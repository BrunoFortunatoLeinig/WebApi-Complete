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
    public class DeleteModel : PageModel
    {
        private readonly Exercícios.Data.ExercíciosContext _context;

        public DeleteModel(Exercícios.Data.ExercíciosContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            DadosIMC = await _context.DadosIMC.FindAsync(id);

            if (DadosIMC != null)
            {
                _context.DadosIMC.Remove(DadosIMC);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
