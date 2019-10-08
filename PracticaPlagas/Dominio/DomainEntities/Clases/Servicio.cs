using PracticaPlagas.Dominio.DomainEntities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaPlagas.Dominio.DomainEntities.Clases
{
    public class Servicio : IServicio
    {    
        public int Id { get; set; }
        public decimal Precio { get; set; }
        public decimal IngresoEmpleado { get; set; }
        public List<IEmpleado> ListaEmpleados { get; set; }
        public IEmpleado JefeEquipo { get; set; }
        public string Animal { get; set; }
        public IVeneno Veneno { get; set; }
        public float Dosis { get; set; }

    }
}
