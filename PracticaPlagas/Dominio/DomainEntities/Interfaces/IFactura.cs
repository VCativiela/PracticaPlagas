using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaPlagas.Dominio.DomainEntities.Interfaces
{
    public interface IFactura
    {
        int Id { get; set; }
        DateTime Fecha { get; set; }
        List<IEncargo> ListaEncargos { get; set; }
    }
}
