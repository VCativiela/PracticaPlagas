using PracticaPlagas.Dominio.DomainEntities.Clases;
using PracticaPlagas.Dominio.DomainEntities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaPlagas.Dominio.DomainService.Factorias
{
    public class ServicioFactory
    {
        public IServicio CreateInstance(int id, string animal, float dosis, decimal precio, decimal ingresoEmpleado)
        {            
            return new Servicio() { Id = id, Animal = animal, Dosis = dosis, IngresoEmpleado = ingresoEmpleado, Precio = precio };
        }
    }
}
