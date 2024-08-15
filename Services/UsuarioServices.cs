using api_cadastro_backend.Model;
using api_cadastro_backend.Model.DTOs.Usuario;
using api_cadastro_backend.Repository.Interfaces;
using api_cadastro_backend.Services.Interfaces;

namespace api_cadastro_backend.Services;

public class UsuarioServices : IUsuarioServices
{
    private readonly IUsuarioRepository repository;

    public UsuarioServices(IUsuarioRepository repository)
    {
        this.repository = repository;
    }

    public UsuarioResponse CreateUser(UsuarioRequest userRequest)
    {
        var user = new Usuario(userRequest.Fullname, userRequest.Email, userRequest.Senha, userRequest.RepitaSenha,
            userRequest.Telefone);

        user = repository.CreateUser(user);

        return new UsuarioResponse(user.Fullname, user.Email, user.Telefone);
    }

    public List<UsuarioResponse> GetUsuarios()
    {
        return repository.GetUsers()
            .Select(user =>
                new UsuarioResponse(user.Fullname, user.Email, user.Telefone))
            .ToList();
    }
}