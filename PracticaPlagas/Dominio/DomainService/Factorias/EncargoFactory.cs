using PracticaPlagas.Dominio.DomainEntities.Clases;
using PracticaPlagas.Dominio.DomainEntities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaPlagas.Dominio.DomainService.Factorias
{
    public class EncargoFactory
    {
        public IEncargo CreateInstance()
        {
            var encargo = new Encargo();

            return encargo;
        }
    }
}
