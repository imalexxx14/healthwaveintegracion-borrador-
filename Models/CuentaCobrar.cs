namespace Cuenta;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class CuentaCobrar
{
    [Key]
    public int IDCuenta { get; set; }
    
    [Column(TypeName = "decimal(10, 2)")]
    public decimal Balance { get; set; }
    
    [Required]
    [MaxLength(1)]
    public char Estado { get; set; }
    
    public string CodigoPaciente { get; set; }
    
    [ForeignKey("CodigoPaciente")]
    public PerfilUsuario PerfilUsuario { get; set; }
}
