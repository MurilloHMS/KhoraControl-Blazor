using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KhoraControl.Domain.Models.Entities;

[Table("user_account_policy")]
public class UserAccountPolicy
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("id")]
    public int Id { get; set; }
    [Column("user_account_id")]
    public int UserAccountId { get; set; }
    [Column("user_policy")]
    public string? UserPolicy { get; set; }
    [Column("is_enabled")]
    public bool IsEnabled { get; set; }
}
