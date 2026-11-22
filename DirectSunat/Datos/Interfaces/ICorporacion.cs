using DirectSunat.Dominio.Entidades;

public interface ICorporacion
{
    void CrearCorporacion(Corporacion corporacion);
    void EditarCorporacion(Corporacion corporacion);
    void EliminarCorporacion(int codigoCorporacion);
    Corporacion? ConsultarCorporacionCodigo(int codigoCorporacion);
    List<Corporacion> ObtenerCorporaciones();
}