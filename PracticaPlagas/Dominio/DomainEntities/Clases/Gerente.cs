using PracticaPlagas.Dominio.DomainEntities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaPlagas.Dominio.DomainEntities.Clases
{
    public class Gerente : IGerente
    {
        public decimal SalarioFijo { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string NombreCompleto { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public decimal DameSalario()
        {
            throw new NotImplementedException();
        }
    }
}
