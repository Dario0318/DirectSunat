using DirectSunat.Dominio.Entidades;

public interface IConfiguracionDocumento
{
    void CrearConfiguracionDocumento(ConfiguracionDocumento configuracionDocumento);
    void EditarConfiguracionDocumento(ConfiguracionDocumento configuracionDocumento);
    void EliminarConfiguracionDocumento(int idConfigDocumento);
    ConfiguracionDocumento? ConsultarConfiguracionDocumentoCodigo(int idConfigDocumento);
    List<ConfiguracionDocumento> ObtenerConfiguracionesDocumento();
}

