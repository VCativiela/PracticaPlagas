using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaPlagas.Dominio.DomainEntities.Interfaces
{
    public interface IEmpleado
    {
        int Id { get; set; }
        string NombreCompleto { get; set; }
        decimal DameSalario();
    }
}
