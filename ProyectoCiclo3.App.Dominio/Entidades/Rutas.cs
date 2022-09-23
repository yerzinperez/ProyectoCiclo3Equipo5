using System;
using System.ComponentModel.DataAnnotations;

namespace ProyectoCiclo3.App.Dominio
{
    public class Rutas
    {
        //objetos de clase
        public int id { get; set; }
        public Estaciones origen { get; set; }
        public Estaciones destino { get; set; }
        [Required]
        public int tiempo_estimado{ get; set; }
    }
}