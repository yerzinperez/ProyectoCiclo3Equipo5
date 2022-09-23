using System;
using System.ComponentModel.DataAnnotations;
namespace ProyectoCiclo3.App.Dominio
{
    
    public class Buses
    {
        //objetos de clase

        public int id { get; set; }

        [Required]
        public string marca {get; set; }
        [Required]
        public string modelo { get; set; }
        [Required]
        public int kilometraje { get; set; }
        [Required]
        public int numero_asientos{ get; set; }
        [Required]
        public string placa { get; set; }
    }
}