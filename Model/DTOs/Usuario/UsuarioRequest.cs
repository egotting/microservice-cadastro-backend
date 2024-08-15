using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices.JavaScript;
using Microsoft.AspNetCore.Mvc.Diagnostics;
using Microsoft.Win32.SafeHandles;

namespace api_cadastro_backend.Model.DTOs.Usuario;

public record UsuarioRequest(
    [Required(ErrorMessage = "Precisa de um valor", AllowEmptyStrings = false)]
    string Fullname,
    [Required(ErrorMessage = "Precisa de um valor", AllowEmptyStrings = false),
     EmailAddress(ErrorMessage = "precisa ser um email valido")]
    string Email,
    [Required(ErrorMessage = "Precisa de um valor", AllowEmptyStrings = false),
     RegularExpression((@"^(?=.*[A-Z])(?=.*[a-z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$"), ErrorMessage =
         "A senha deve conter no mínimo 8 caracteres, incluindo uma letra maiúscula, uma letra minúscula, um número e um caractere especial.")]
    string Senha,
    [Required(ErrorMessage = "A confirmação da senha é obrigatorio")]
    string RepitaSenha,
    [Required(ErrorMessage = "Precisa por um valor", AllowEmptyStrings = false),
     Phone(ErrorMessage = "Isto n é um numero de telefone")]
    string Telefone
);