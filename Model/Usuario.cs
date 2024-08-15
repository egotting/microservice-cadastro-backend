using System.ComponentModel.DataAnnotations;

namespace api_cadastro_backend.Model;

public class Usuario
{
    [Key] public int Id { get; set; }

    [Required(ErrorMessage = "precisa por um valor", AllowEmptyStrings = false)]
    public string Fullname { get; set; }

    [Required(ErrorMessage = "Precisa de um valor", AllowEmptyStrings = false),
     EmailAddress(ErrorMessage = "precisa ser um email valido")]
    public string Email { get; set; }

    [Required(ErrorMessage = "Precisa de um valor", AllowEmptyStrings = false),
     RegularExpression((@"^(?=.*[A-Z])(?=.*[a-z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$"), ErrorMessage =
         "A senha deve conter no mínimo 8 caracteres, incluindo uma letra maiúscula, uma letra minúscula, um número e um caractere especial.")]
    public string Senha { get; set; }

    [Required(ErrorMessage = "A confirmação da senha é obrigatorio")]
    [Compare("Senha", ErrorMessage = "A Senha e a confirmação da senha não correspondem")]
    public string RepitaSenha { get; set; }

    [Required(ErrorMessage = "Precisa por um valor", AllowEmptyStrings = false), Phone(ErrorMessage = "Isto n é um numero de telefone")]
    public string Telefone { get; set; }
    
    public DateTime DataDoCadastro { get; set; }

    public Usuario()
    {
        
    }

    public Usuario(string fullname, string email, string senha, string repitaSenha, string telefone)
    {
        Fullname = fullname;
        Email = email;
        Senha = senha;
        RepitaSenha = repitaSenha;
        Telefone = telefone;
        DataDoCadastro = DateTime.Now;
    }
}