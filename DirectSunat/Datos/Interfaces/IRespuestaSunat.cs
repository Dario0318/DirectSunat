using DirectSunat.Dominio.Entidades;

public interface IRespuestaSunat
{
    void CrearRespuestaSunat(RespuestaSunat respuestaSunat);
    RespuestaSunat? ConsultarRespuestaSunatCodigo(int idDocumento);
    List<RespuestaSunat> ObtenerRespuestasSunat();
}

