namespace PracticaPlagas.Dominio.DomainEntities.Interfaces
{
    public interface ICliente
    {
        int Id { get; set; }
        string NombreCompleto { get; set; }
        string CP { get; set; }
        string Email { get; set; }
        string Telefono { get; set; }
    }
}