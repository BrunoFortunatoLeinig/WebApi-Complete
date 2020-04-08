using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Exercícios.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }

        [BindProperty]
        public string Login { get; set; }
        [BindProperty]
        public string Password { get; set; }

        public void OnPost()
        {
            var userResult = Exercícios.Dto.User.GetUser(Login);
            if (userResult != null)
            {
                if (userResult.Password == Password)
                {
                    if (userResult.Active)
                    {
                        Response.Redirect("/PaginaInicial");
                    }
                    else
                    {
                        this.Login = ("Usuário não Ativo");
                    }
                }
                else
                {
                    this.Login = ("Senha Incorreta");

                }
            }
            else
            {
                this.Login = ("Usuário não encontrado");
            }
        }
    }
}
