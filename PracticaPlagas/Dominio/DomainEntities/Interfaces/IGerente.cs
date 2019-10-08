using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaPlagas.Dominio.DomainEntities.Interfaces
{
    public interface IGerente : IEmpleado
    {
        decimal SalarioFijo { get; set; }
    }
}
