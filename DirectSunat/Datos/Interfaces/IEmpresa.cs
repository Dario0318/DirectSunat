using DirectSunat.Dominio.Entidades;

public interface IEmpresa
{
    void CrearEmpresa(Empresa empresa);
    void EditarEmpresa(Empresa empresa);
    void EliminarEmpresa(int codigoEmpresa);
    Empresa? ConsultarEmpresaCodigo(int codigoEmpresa);
    List<Empresa> ObtenerEmpresas();
}