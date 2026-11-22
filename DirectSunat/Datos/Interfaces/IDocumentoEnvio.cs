using DirectSunat.Dominio.Entidades;

public interface IDocumentoEnvio
{
    void CrearDocumentoEnvio(RespuestaSunat documentoEnvio);
    void EditarDocumentoEnvio(RespuestaSunat documentoEnvio);
    void EliminarDocumentoEnvio(int idDocumento);
    RespuestaSunat? ConsultarDocumentoEnvioCodigo(int idDocumento);
    List<RespuestaSunat> ObtenerDocumentosEnvio();
}

