using PracticaPlagas.Dominio.DomainEntities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaPlagas.Dominio.DomainEntities.Clases
{
    public class Recurso : IRecurso
    {
        public string Nombre { get; set; }
        public decimal Coste { get; set; }
    }
}
