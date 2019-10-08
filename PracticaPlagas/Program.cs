using Autofac;
using PracticaPlagas.Dominio.DomainEntities.Interfaces;
using PracticaPlagas.Dominio.DomainEntities.Clases;
using PracticaPlagas.Dominio.DomainService.Clases;
using PracticaPlagas.Dominio.DomainService.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PracticaPlagas.Dominio.DomainService.Factorias;

namespace PracticaPlagas
{
    class Program
    {
        private static IContainer Container { get; set; }
        private static IEmpresa Empresa { get; set; }
    
        static void Main(string[] args)
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<GeneradorFacturas>().As<IGeneradorFacturas>();
            Container = builder.Build();

            var empresaFactory = new EmpresaFactory();
            var empresa = empresaFactory.CreateInstance();

            var serviciosFactory = new ServicioFactory();
            empresa.ListaServicios.Add(serviciosFactory.CreateInstance(1, "Rata", 2.0f, 20.0M, 15.0M));
            empresa.ListaServicios.Add(serviciosFactory.CreateInstance(2, "Cucaracha", 2.0f, 20.0M, 15.0M));
            empresa.ListaServicios.Add(serviciosFactory.CreateInstance(3, "Termitas", 2.0f, 20.0M, 15.0M));
            empresa.ListaServicios.Add(serviciosFactory.CreateInstance(4, "Abejas", 2.0f, 20.0M, 15.0M));
        }
    }
}
