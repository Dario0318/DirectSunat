using DirectSunat.Dominio.Entidades;

public interface IUsuario
{
    void CrearUsuario(Usuario usuario);
    void EditarUsuario(Usuario usuario);
    void EliminarUsuario(int CodigoUsuario);
    Usuario ObtenerUsuarioCodigo(int CodigoUsuario);
    List<Usuario> ObtenerUsuarios();
}