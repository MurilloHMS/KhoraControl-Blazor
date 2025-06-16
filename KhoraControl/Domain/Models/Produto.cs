using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace KhoraControl.Domain.Models
{
    [Table("Produtos")]
    public class Produto : ValidationClass
    {
        [Key]
        [Column("PRONID_PRO")]
        public int Id { get; set; } // ID Produto

        [Required(ErrorMessage = "É necessário preencher a data de validade")]
        [Column("PRODDATCAD")]
        public DateTime DataCadastro { get; set; } // Data Lançamento

        [Column("PROCCODINT")]
        public string? CodigoInterno { get; set; } // Código interno

        [Required(ErrorMessage = "É necessário preencher a descrição do produto")]
        [Column("PROCDESCR")]
        public string Descricao { get; set; } // Descrição do produto

        [Column("PROCREF")]
        public string? ReferenciaFornecedor { get; set; } // Referência Fornecedor

        [Required(ErrorMessage = "É necessário preencher o fornecedor do produto")]
        [Column("PROCFOR")]
        public string Fornecedor { get; set; }

        [Required(ErrorMessage = "É necessário preencher a quantidade do produto")]
        [RegularExpression("([0-9]+)", ErrorMessage = "A Quantidade deve conter apenas Números")]
        [Column("PRONQUANT")]
        public int Quantidade { get; set; }

        [Column("PRODDATVAL")]
        public DateTime? DataValidade { get; set; }

        [Column("PROCSTAT")]
        public string? Status { get; set; }

        [Column("PROCNNUMNF")]
        public string? NumeroNotaFiscal { get; set; }

        [Column("PRODDATALT")]
        public DateTime? DataAlteracao { get; set; }

        [Column("PROCUSRCAD")]
        public string? UsuarioCadastro { get; set; }

        [Column("PROCUSRALT")]
        public string? UsuarioAlteracao { get; set; }
    }

}
