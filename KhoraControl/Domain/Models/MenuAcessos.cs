using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KhoraControl.Domain.Models
{
    public class MenuAcessos
    {
        [Key]
        public int ID {  get; set; }
        [Key]
        public int Id_Usuario {  get; set; }
        [Key]
        public int Id_Opcao { get; set; }
        public char Liberado { get; set; } = 'F';

    }


}
