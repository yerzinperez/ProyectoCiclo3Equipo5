using System;
using System.ComponentModel.DataAnnotations;
namespace ProyectoCiclo3.App.Dominio{
    public class Estaciones {
        //objetos de clase
        public int id { get; set; }
        [Required]
        public string nombre { get; set; }
        [Required]
        public string direccion { get; set; }
        [Required]
        public string coord_x { get; set; }
        [Required]
        public string coord_y { get; set; }
        [Required]
        public string tipo { get; set; }
    }    
}