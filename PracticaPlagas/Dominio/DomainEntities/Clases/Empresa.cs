using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PracticaPlagas.Dominio.DomainEntities.Interfaces;
using PracticaPlagas.Dominio.DomainService.Interfaces;

namespace PracticaPlagas.Dominio.DomainEntities.Clases
{
    public class Empresa : IEmpresa
    {
        public IGerente Gerente { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public List<IEmpleado> ListaEmpleados { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public List<ICliente> ListaClientes { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public List<IServicio> ListaServicios { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public List<IEncargo> ListaEncargos { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public List<IFactura> ListaFacturas { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public IGeneradorFacturas GeneradorFacturas { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public ICalculadoraCuentasEmpresa CalculadorCuentas { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public ICalculadoraSalarios CalculadoraSalarios { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        //public void GenerarFacturas()
        //{
        //    GeneradorFacturas.GenerarFacturas(ListaEncargos);
        //}

        public decimal DameFacturado()
        {
            throw new NotImplementedException();
        }

        public decimal DameFacturadoCliente(int IdCliente)
        {
            throw new NotImplementedException();
        }

        public decimal DameResultadoEmpresa()
        {
            throw new NotImplementedException();
        }

        public void InsertaServicio()
        {
            throw new NotImplementedException();
        }

        public void GenerarFacturas(List<IEncargo> listaEncargos)
        {
            throw new NotImplementedException();
        }

        public void GenerarFacturas(List<IEncargo> listaEncargos, int Mes)
        {
            throw new NotImplementedException();
        }
    }
}
