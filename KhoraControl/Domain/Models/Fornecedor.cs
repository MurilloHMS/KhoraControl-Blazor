using System.Threading.Tasks;
namespace KhoraControl.Domain.Models
{
    public class Fornecedor : Enderecos
    {
        public int ID { get; set; } //ID
        public string? CNPJ { get; set; } //CNPJ FORNECEDOR
        public string? RazaoSocial { get; set; } //RAZÃO SOCIAL
        public string? NomeFantasia { get; set; } //NOME FANTASIA
        public string? InscricaoEstadual { get; set; } //INSCRIÇÃO ESTADUAL
        public string? CodRegimeTributario { get; set; } //CÓDIGO REGIME TRIBUTÁRIO
        
     
	}


    

}
