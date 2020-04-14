using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Exercícios.Pages
{
    public class CadastrarModel : PageModel
    {
        private readonly ILogger<CadastrarModel> _logger;

        [BindProperty]
        public string Create { get; set; }

        public CadastrarModel(ILogger<CadastrarModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }

        public void OnPost()
        {
            var usuario = Request.Form["Usuario"];
            var senha = Request.Form["Senha"];
            this.Create = Convert.ToString(Exercícios.Dto.User.PostUser(new Dto.UserModel()));
            Exercícios.Dto.User.PostUser(new Dto.UserModel()
            {
                Active = true,
                Name = usuario,
                Password = senha
            });

            Response.Redirect("/index");
        }
    }
}
