using System.Collections.Generic;
using ProyectoCiclo3.App.Dominio;
using System.Linq;
using System;
 
namespace ProyectoCiclo3.App.Persistencia.AppRepositorios{

    public class RepositorioRutas{

        List<Rutas> rutas;
        private readonly AppContext _appContext = new AppContext();
 
        public RepositorioRutas(){}
 
        public IEnumerable<Rutas> GetAll()
        {
            return _appContext.Rutas;
        }
 
        public Rutas GetWithId(int id){
            return _appContext.Rutas.Find(id);
        }

        public Rutas Create(Rutas newRuta){
            var addRuta = _appContext.Rutas.Add(newRuta);
            _appContext.SaveChanges();
            return addRuta.Entity;
        }


        public Rutas Delete(int id){
            var ruta= rutas.SingleOrDefault(b => b.id == id);
            rutas.Remove(ruta);
            return ruta;
            }
    }
}