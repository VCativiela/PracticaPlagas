using System.Collections.Generic;

namespace PracticaPlagas.Dominio.DomainEntities.Interfaces
{
    public interface IServicio
    {
        int Id { get; set; }
        string Animal { get; set; }
        IVeneno Veneno { get; set; }
        float Dosis { get; set; }
        decimal Precio { get; set; }
        decimal IngresoEmpleado { get; set; }
        List<IEmpleado> ListaEmpleados { get; set; }
        IEmpleado JefeEquipo { get; set; }
    }
}