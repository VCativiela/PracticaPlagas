using PracticaPlagas.Dominio.DomainEntities.Interfaces;
using PracticaPlagas.Dominio.DomainService.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaPlagas.Dominio.DomainService.Clases
{
    public class GeneradorFacturas : IGeneradorFacturas
    {
        public List<IFactura> GenerarFacturas(List<IEncargo> listaEncargos)
        {
            //Agrupar por ID Cliente
            //Seleccionar servicios de un mes
            return null;
        }
    }
}
