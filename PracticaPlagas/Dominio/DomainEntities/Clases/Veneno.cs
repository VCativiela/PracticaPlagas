using PracticaPlagas.Dominio.DomainEntities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaPlagas.Dominio.DomainEntities.Clases
{
    public class Veneno : IVeneno
    {
        public string Nombre { get; set; }
        public decimal Dosis { get; set; }
        public decimal Coste { get; set; }
    }
}
