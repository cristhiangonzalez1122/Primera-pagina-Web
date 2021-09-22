using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HolaWeb.App.FrontEnd.Pages
{

    
    public class listModel : PageModel
    {
        private string[] saludos = {"Buenos Dias","Buenas Tardes", "Buenas Noches", "Hasta Mañana"};
        public List<string> ListaSaludos {get;set;}
        public void OnGet()
        {
            ListaSaludos = new List<string>();
            ListaSaludos.AddRange(saludos);
        }
    }
}
