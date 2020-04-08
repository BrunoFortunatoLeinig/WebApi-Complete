using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Exercícios.Data;
using Exercícios.Models;

namespace Exercícios.Pages.Exer9
{
    public class EditModel : PageModel
    {
        private readonly Exercícios.Data.ExercíciosContext _context;

        public EditModel(Exercícios.Data.ExercíciosContext context)
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

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(DadosIMC).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DadosIMCExists(DadosIMC.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool DadosIMCExists(int id)
        {
            return _context.DadosIMC.Any(e => e.ID == id);
        }
    }
}
