namespace Cuenta;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Factura
{
    [Key]
    [MaxLength(30)]
    public string FacturaCodigo { get; set; }
    
    [Column(TypeName = "decimal(10, 2)")]
    public decimal MontoTotal { get; set; }
    
    [Column(TypeName = "decimal(10, 2)")]
    public decimal MontoSubtotal { get; set; }
    
    [Required]
    public DateTime Fecha { get; set; }
    
    [MaxLength(50)]
    public string RNC { get; set; }
    
    public int CodigoMetodoDePago { get; set; }
    
    public string CodigoPaciente { get; set; }
    
    public int IDIngreso { get; set; }
    
    public int IDCuenta { get; set; }
    
    public int ConsultaCodigo { get; set; }

    [ForeignKey("CodigoMetodoDePago")]
    public MetodoDePago MetodoDePago { get; set; }
    
    [ForeignKey("CodigoPaciente")]
    public PerfilUsuario Paciente { get; set; }
    
    [ForeignKey("IDIngreso")]
    public Ingreso Ingreso { get; set; }
    
    [ForeignKey("IDCuenta")]
    public CuentaCobrar CuentaCobrar { get; set; }
    
    [ForeignKey("ConsultaCodigo")]
    public Consulta Consulta { get; set; }
}
