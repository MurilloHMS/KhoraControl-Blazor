using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KhoraControl.Domain.Models
{
	public class Enderecos
	{
		public string? Logradouro { get; set; } //LOGRADOURO
		public string? Numero { get; set; } //NÚMERO
		public string? Complemento { get; set; } //COMPLEMENTO
		public string? Bairro { get; set; } //BAIRRO
		public string? Municipio { get; set; } //MUNICIPIO
		public string? UF { get; set; } //UF
		public string? CEP { get; set; } //CEP
		public string? CodigoPais { get; set; } //CODIGO PAIS
		public string? Pais { get; set; } //NOME PAIS
		public string? Telefone { get; set; } //TELEFONE
	}
}
