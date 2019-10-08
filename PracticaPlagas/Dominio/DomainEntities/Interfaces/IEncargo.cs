using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaPlagas.Dominio.DomainEntities.Interfaces
{
    public interface IEncargo
    {
        int IdServicio { get; set; }
        int IdCliente { get; set; }
        DateTime Fecha { get; set; }
    }
}
