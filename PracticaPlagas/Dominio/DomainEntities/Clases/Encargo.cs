using PracticaPlagas.Dominio.DomainEntities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaPlagas.Dominio.DomainEntities.Clases
{
    public class Encargo : IEncargo
    {
        public int IdServicio { get; set; }
        public int IdCliente { get; set; }
        public DateTime Fecha { get; set; }
    }
}
