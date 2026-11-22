using DirectSunat.Dominio.Entidades;
using DirectSunat.Negocio.DTOs;

public interface ICorporacionServicio
{
    List<CorporacionDTO> ListarCorporaciones();
    void RegistrarNuevaCorporacion(CorporacionDTO corporacionDTO);
    void EditarCorporacion(CorporacionDTO corporacionDTO);
    void EliminarCorporacion(int codigoCorporacion);
}