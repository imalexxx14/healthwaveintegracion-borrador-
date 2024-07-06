namespace Cuenta;
using System.ComponentModel.DataAnnotations;

public class Sala
{
    [Key]
    public int NumSala { get; set; }
    
    [Required]
    [MaxLength(50)]
    public string Estado { get; set; }
}