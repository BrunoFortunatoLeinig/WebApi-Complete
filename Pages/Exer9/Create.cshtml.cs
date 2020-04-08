using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Exercícios.Data;
using Exercícios.Models;

namespace Exercícios.Pages.Exer9
{
    public class CreateModel : PageModel
    {
        private readonly Exercícios.Data.ExercíciosContext _context;

        public CreateModel(Exercícios.Data.ExercíciosContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public DadosIMC DadosIMC { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            DadosIMC.IMC = (DadosIMC.Massa / (Convert.ToDecimal(DadosIMC.Altura) * Convert.ToDecimal(DadosIMC.Altura)));

            _context.DadosIMC.Add(DadosIMC);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
