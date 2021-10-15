using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Mintic.App.Presentacion
{
    public class LoginModel : PageModel
    {
        private  Mintic.App.Persistencia.AppRepositories.Conexion conexion;


        [BindProperty]
        public string Usuario {get;set;}

        [BindProperty]
        public string Password {get;set;}

        [BindProperty]
        public string MensajeUsuario {get;set;}

        public string MensajePassword {get;set;}

        public void OnGet()
        {
        
        }
        public IActionResult OnPost()
        {
            conexion = new App.Persistencia.AppRepositories.Conexion();

            var p = conexion.Personas.FirstOrDefault(p => p.Usuario == Usuario);
            //System.Console.WriteLine(p.Password);
            if (p == null){
                MensajeUsuario = "Usuario no registrado";
            }
            else if (!p.Password.Equals(Password)){
                MensajePassword = "Contraseña no valida";
            }
            else{
                return RedirectToPage("../Index");
            }
            return Page();
        }
    }
}
