using PracticaPlagas.Dominio.DomainEntities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaPlagas.Dominio.DomainService.Interfaces
{
    public interface IBeneficioServicio
    {
        bool IsSatisfiedBy(IServicio servicio);
    }
}
