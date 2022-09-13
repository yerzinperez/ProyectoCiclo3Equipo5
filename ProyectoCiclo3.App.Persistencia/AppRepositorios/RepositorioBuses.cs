using System.Collections.Generic;
using ProyectoCiclo3.App.Dominio;
using System.Linq;
using System;
 
namespace ProyectoCiclo3.App.Persistencia.AppRepositorios{
    public class RepositorioBuses{
        List<Buses> buses;
        private readonly AppContext _appContext = new AppContext();
 
        public RepositorioBuses(){}
 
            public IEnumerable<Buses> GetAll(){
                return _appContext.Buses;
            }
 
            public Buses GetWithId(int id){
                return _appContext.Buses.Find(id);
            }

            public Buses Create(Buses newBus){
                var addBus = _appContext.Buses.Add(newBus);
                _appContext.SaveChanges();
                return addBus.Entity;
            }


            public Buses Update(Buses newBus){
                var bus = _appContext.Buses.Find(newBus.id);
                if(bus != null){
                    bus.marca = newBus.marca;
                    bus.modelo = newBus.modelo;
                    bus.kilometraje = newBus.kilometraje;
                    bus.numero_asientos = newBus.numero_asientos;
                    bus.placa = newBus.placa;
                    _appContext.SaveChanges();
                }
                return bus;
            }

            public Buses Delete(int id){
                var bus= _appContext.Buses.Find(id);
                if(bus != null){
                    _appContext.Buses.Remove(bus);
                    _appContext.SaveChanges();
                }
                return null;
            }
    }
}
