using System.ComponentModel.DataAnnotations;
using System.Security.Policy;
using System.Text;


namespace KhoraControl.Domain.Models
{
    public class Usuarios : Entidades
    {
        [Key]
        public int ID { get; set; }
        [Required(ErrorMessage="O Nome é Obrigatório")]
        [StringLength(200, ErrorMessage = "O Tamanho máximo do campo Nome é 200 caracteres")]
        public string Nome { get; set; }
        [StringLength(200, ErrorMessage = "O Tamanho máximo do campo E-mail é 200 caracteres")]
        public string? Email { get; set; }
        [Required(ErrorMessage = "A Senha é Obrigatória")]
        [StringLength(100, ErrorMessage = "O Tamanho máximo do campo Senha é 100 caracteres")]
        public string Senha { get; set; }
        public char Ativo { get; set; }
    }
}
