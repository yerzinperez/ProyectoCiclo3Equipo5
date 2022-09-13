using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProyectoCiclo3.App.Persistencia.AppRepositorios;
using ProyectoCiclo3.App.Dominio;

namespace ProyectoCiclo3.App.Frontend.Pages {

    public class FormRutasModel : PageModel {

        private readonly RepositorioEstaciones repositorioEstaciones;
        private readonly RepositorioRutas repositorioRutas;
        public IEnumerable<Estaciones> Estaciones{get;set;}
        public Rutas Rutas { get;set;}

        public FormRutasModel(RepositorioEstaciones repositorioEstaciones, RepositorioRutas repositorioRutas){
            this.repositorioEstaciones = repositorioEstaciones;
            this.repositorioRutas= repositorioRutas;
        }

        public void OnGet(){
            Estaciones = repositorioEstaciones.GetAll();
            Rutas = repositorioRutas.GetAll();
        }

        public IActionResult OnPost(){
            if(!ModelState.IsValid){
                return Page();
            }            
            Rutas = repositorioRutas.Create(Rutas);            
            return RedirectToPage("./List");
        }
    }
}
