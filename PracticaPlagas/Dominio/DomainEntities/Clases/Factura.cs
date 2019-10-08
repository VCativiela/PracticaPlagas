using PracticaPlagas.Dominio.DomainEntities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaPlagas.Dominio.DomainEntities.Clases
{
    public class Factura : IFactura
    {
        public DateTime Fecha { get; set; }
        public int Id { get; set; }
        public List<IEncargo> ListaEncargos { get; set; }
    }
}
