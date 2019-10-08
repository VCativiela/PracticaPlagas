using PracticaPlagas.Dominio.DomainEntities.Clases;
using PracticaPlagas.Dominio.DomainEntities.Interfaces;
using PracticaPlagas.Dominio.RepositoryInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaPlagas.InfraestructuraDePersistencia.Repositorios
{
    class FakeRepository : IRepository
    {
        private List<ICliente> _listaClientes;
        private List<IVeneno> _listaVenenos;
        private List<IEmpleado> _listaPeones;
        private List<IServicio> _listaServicios;
        private List<IRecurso> _listaRecursos;
        private List<IEncargo> _listaEncargos;

        public FakeRepository()
        {
            _listaClientes = new List<ICliente>()
            {
                new Cliente {Id=1, NombreCompleto="Manolo Gomez", CP="50213", Email="m.gomez@hotmail.com", Telefono="972134813"},
                new Cliente {Id=2, NombreCompleto="Cristina Sanz", CP="40123", Email="cris@gmail.com", Telefono="666131413"},
                new Cliente {Id=3, NombreCompleto="Pedro Hernandez", CP="35111", Email="phernandez@gmail.com", Telefono="900202560"},
                new Cliente {Id=4, NombreCompleto="Maria Sanchez", CP="50323", Email="maria@gmail.com", Telefono="678016090"},
            };

            _listaRecursos = new List<IRecurso>()
            {
                new Recurso { Coste=15.0M, Nombre = "Coche" },
                new Recurso { Coste=17.0M, Nombre = "Furgoneta" },
                new Recurso { Coste=17.0M, Nombre = "Furgoneta" },
                new Recurso { Coste=17.0M, Nombre = "Furgoneta" },
                new Recurso { Coste=3.5M, Nombre = "Mascarillas" },
            };

            _listaVenenos = new List<IVeneno>()
            {
                new Veneno { Coste=15.0M, Nombre = "Mataratas", Dosis=5 },
                new Veneno { Coste=5.0M, Nombre = "Matacucarachas", Dosis=15 },
                new Veneno { Coste=24.0M, Nombre = "Matatermitas", Dosis=3 },
            };

            _listaServicios = new List<IServicio>()
            {
                new Servicio {  Id=1, Animal = "Rata", Veneno = _listaVenenos[0], Dosis = 10, IngresoEmpleado=40, Precio=35,
                    JefeEquipo =_listaPeones[1], ListaEmpleados = new List<IEmpleado> { _listaPeones[0], _listaPeones[1], _listaPeones[2], _listaPeones[3] } },
                new Servicio {  Id=2, Animal = "Cucarachas", Veneno = _listaVenenos[1], Dosis = 10, IngresoEmpleado=40, Precio=35,
                    JefeEquipo =_listaPeones[2], ListaEmpleados = new List<IEmpleado> { _listaPeones[0], _listaPeones[1], _listaPeones[2], _listaPeones[3] } },
                new Servicio {  Id=3, Animal = "Termitas", Veneno = _listaVenenos[2], Dosis = 10, IngresoEmpleado=40, Precio=35,
                    JefeEquipo =_listaPeones[4], ListaEmpleados = new List<IEmpleado> { _listaPeones[0], _listaPeones[1], _listaPeones[2], _listaPeones[3] } },
            };

            _listaPeones = new List<IEmpleado>()
            {
                //new Empleado {Id=1, NombreCompleto="Maria Sanchez", CP="50213", Email="maria@gmail.com", Telefono="678016090"},
            };

        }

        public List<ICliente> Clientes()
        {
            return _listaClientes;
        }

        public List<IEncargo> Encargos()
        {
            return _listaEncargos;
        }

        public List<IServicio> Servicios()
        {
            return _listaServicios;
        }

        List<Cliente> IRepository.Clientes()
        {
            throw new NotImplementedException();
        }

        List<Encargo> IRepository.Encargos()
        {
            throw new NotImplementedException();
        }

        List<Servicio> IRepository.Servicios()
        {
            throw new NotImplementedException();
        }
    }
}
