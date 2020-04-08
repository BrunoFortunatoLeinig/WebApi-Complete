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

        public CadastrarModel(ILogger<CadastrarModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }

        public static class User
        {
            private static List<UserModel> _lstUser;

            public static List<UserModel> GetUser()
            {
                return _lstUser;
            }
            public static UserModel GetUser(string user)
            {
                return _lstUser.Where(x => x.Name == user).SingleOrDefault();
            }

            public static void LoadUser()
            {
                _lstUser = new List<UserModel>()
            {
                new UserModel(){
                    Name = "bruno",
                    Password = "123",
                    Active = true
                }
            };
            }
            public static string PostUser(UserModel User)
            {
                try
                {
                    _lstUser.Add(User);
                    return "Add user success!";
                }
                catch (Exception ex)
                {
                    return "Error add user!";
                }
            }

        }

        public class UserModel
        {
            public string Name { get; set; }
            public string Password { get; set; }
            public bool Active { get; set; }
        }
    }
}
