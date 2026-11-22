using DirectSunat.Dominio.Entidades;
using DirectSunat.Negocio.DTOs;

public interface IRespuestaSunatServicio
{
    List<RespuestaSunatDTO> ListarRespuestasSunat();
    void RegistrarNuevaRespuestaSunat(RespuestaSunatDTO respuestaSunatDTO);
    RespuestaSunatDTO? ConsultarRespuestaSunatCodigo(int idDocumento);
}

