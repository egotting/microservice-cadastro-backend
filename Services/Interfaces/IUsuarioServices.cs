using api_cadastro_backend.Model.DTOs.Usuario;

namespace api_cadastro_backend.Services.Interfaces;

public interface IUsuarioServices
{
    UsuarioResponse CreateUser(UsuarioRequest user);
    List<UsuarioResponse> GetUsuarios();
    
}