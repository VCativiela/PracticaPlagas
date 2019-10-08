using PracticaPlagas.Dominio.DomainService.Interfaces;
using System.Collections.Generic;

namespace PracticaPlagas.Dominio.DomainEntities.Interfaces
{
    public interface IEmpresa
    {
        IGerente Gerente { get; set; }
        List<IEmpleado> ListaEmpleados { get; set; }
        List<ICliente> ListaClientes { get; set; }
        List<IServicio> ListaServicios { get; set; }
        List<IEncargo> ListaEncargos { get; set; }
        List<IFactura> ListaFacturas { get; set; }

        IGeneradorFacturas GeneradorFacturas { get; set; }
        ICalculadoraCuentasEmpresa CalculadorCuentas { get; set; }
        ICalculadoraSalarios CalculadoraSalarios { get; set; }

        //void SetGeneradorFacturas(IGeneradorFacturas generadorFacturas);
        //void SetCalculadoraSalariosFacturas(ICalculadoraSalarios calculadoraSalarios);
        //void SetCalculadoraCuentasEmpresa(ICalculadoraCuentasEmpresa calculadoraCuentasEmpresa);

        decimal DameResultadoEmpresa();
        decimal DameFacturado();
        decimal DameFacturadoCliente(int idCliente);
        void GenerarFacturas(List<IEncargo> listaEncargos, int Mes);
    }
}