using System.ComponentModel.DataAnnotations;


namespace KhoraControl.Domain.Models
{
    public class Produto : Entidades
    {
        [Key]
        public int PRONID_PRO { get; set; } //ID Produto
        [Required(ErrorMessage = "É necessario preencher a data de validade")]
        public DateTime PRODDATCAD { get; set; } //Data Lançamento
        public string? PROCCODINT { get; set; } // Codigo interno
        [Required(ErrorMessage = "É necessario preencher a descrição do produto")]
        public string PROCDESCR { get; set; } //Descrição do produto
        public string? PROCREF { get; set; } //Referencia Fornecedor
        [Required(ErrorMessage = "É necessario preencher o fornecedor do produto")]
        public string PROCFOR { get; set; } //Fornecedor
        [Required(ErrorMessage = "É necessario preencher a quantidade do produto")]
        [RegularExpression("([0-9]+)", ErrorMessage = "A Quantidade deve conter apenas Números")]
        public int PRONQUANT { get; set; } //Quantidade
        public DateTime PRODDATVAL { get; set; }//Data Validade
        public string? PROCSTAT { get; set; } // Status
        public string? PROCNNUMNF { get; set; } //Número NFe
        public DateTime? PRODDATALT { get; set; }
        public string? PROCUSRCAD { get; set; }
        public string? PROCUSRALT { get; set; }
	}	    

}
