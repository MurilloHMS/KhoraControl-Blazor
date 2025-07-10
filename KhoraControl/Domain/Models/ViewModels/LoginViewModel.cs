using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KhoraControl.Domain.Models.ViewModels;

public class LoginViewModel
{
    [Required(AllowEmptyStrings = false, ErrorMessage = "O nome de usuário é obrigatório.")]
    public string? Username { get; set; }
    [Required(AllowEmptyStrings = false, ErrorMessage = "A senha é obrigatória.")]
    [DataType(DataType.Password)]
    public string? Password { get; set; }
}
