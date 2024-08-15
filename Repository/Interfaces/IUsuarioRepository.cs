using api_cadastro_backend.Model;

namespace api_cadastro_backend.Repository.Interfaces;

public interface IUsuarioRepository
{

    IEnumerable<Usuario> GetUsers();

    Usuario CreateUser(Usuario user);
}