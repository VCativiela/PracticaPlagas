using PracticaPlagas.Dominio.DomainEntities.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaPlagas.Dominio.RepositoryInterfaces
{
    interface IRepository
    {
        List<Cliente> Clientes();
        List<Servicio> Servicios();
        List<Encargo> Encargos();

    }
}
