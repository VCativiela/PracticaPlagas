using PracticaPlagas.Dominio.DomainEntities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaPlagas.Dominio.DomainEntities.Clases
{
    class Cliente : ICliente
    {
        public int Id { get; set; }
        public string NombreCompleto { get; set; }
        public string CP { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
    }
}
