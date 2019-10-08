using PracticaPlagas.Dominio.DomainEntities.Clases;
using PracticaPlagas.Dominio.DomainEntities.Interfaces;
using PracticaPlagas.Dominio.DomainService.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaPlagas.Dominio.DomainService.Clases
{
    public class BeneficioPorServicio : IBeneficioServicio
    {
        public bool IsSatisfiedBy(IServicio servicio)
        {
            var costesServicio = servicio.ListaEmpleados.Count() * servicio.IngresoEmpleado * 1.15M;
            return (servicio.Precio == costesServicio);
        }
    }
}
