using api_cadastro_backend.Model.DTOs.Usuario;
using api_cadastro_backend.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace api_cadastro_backend.Controller;

[ApiController]
[Route("/Usuario")]
public class Usuario : Microsoft.AspNetCore.Mvc.Controller
{
    private readonly IUsuarioServices services;

    public Usuario(IUsuarioServices services)
    {
        this.services = services;
    }

    [HttpGet]
    [Route("/usuarios")]
    public IActionResult GetUsers()
    {
        return Ok(services.GetUsuarios());
    }

    [HttpPost]
    [Route("/Register")]
    public IActionResult CreateUser([FromBody] UsuarioRequest userRequest)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        var result = services.CreateUser(userRequest);
        return Ok(result);
    }
}