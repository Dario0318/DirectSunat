using DirectSunat.Dominio.Entidades;

public interface ITipoDocumentoEmpresa
{
    void CrearTipoDocumentoEmpresa(TipoDocumentoEmpresa tipDocEmp);
    void EditarTipoDocumentoEmpresa(TipoDocumentoEmpresa tipDocEmp);
    void EliminarTipoDocumentoEmpresa(int idTipoDocumentoEmpresa);
    void EstadoTipoDocumentoEmpresa(TipoDocumentoEmpresa tipDocEmp, bool IndicadorActivacion);
    TipoDocumentoEmpresa? ConsultarTipoDocumentoEmpresaCodigo(int idTipoDocumentoEmpresa);
    List<TipoDocumentoEmpresa> ObtenerTiposDocumentoEmpresa();
}

