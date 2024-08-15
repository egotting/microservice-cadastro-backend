using api_cadastro_backend.Model;
using api_cadastro_backend.Repository.Interfaces;

namespace api_cadastro_backend.Repository;

public class UsuarioRepository : IUsuarioRepository
{
    private readonly Context context;

    public UsuarioRepository(Context context)
    {
        this.context = context;
    }

    public IEnumerable<Usuario> GetUsers()
    {
        return context.Usuarios.ToList();
    }

    public Usuario CreateUser(Usuario user)
    {
        context.Usuarios.Add(user);
        context.SaveChanges();
        return user;
    }
}