using PracticaPlagas.Dominio.DomainEntities.Clases;
using PracticaPlagas.Dominio.DomainEntities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaPlagas.Dominio.DomainService.Factorias
{
    public class EmpresaFactory
    {
        public IEmpresa CreateInstance()
        {
            var empresa = new Empresa();
            //Aquí utilizaría AUTOFAC para DI de los parámetros de empresa: 
            //IGeneradorFacturas, ICalculadoraSalarios,ICalculadoraCuentasEmpresa


            //using (var scope = Container.BeginLifetimeScope())
            //{
            //    var generadorFacturas = scope.Resolve<IGeneradorFacturas>();

            //    var empresa = new Empresa(generadorFacturas);
            //}
            //return empresa;

            return empresa;
        }
    }
}
