namespace Cuenta;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Ingreso
{
    [Key]
    public int IDIngreso { get; set; }
    
    [Column(TypeName = "decimal(10, 2)")]
    public decimal CostoEstancia { get; set; }
    
    [Required]
    public DateTime FechaIngreso { get; set; }
    
    public DateTime? FechaAlta { get; set; }
    
    public int NumSala { get; set; }
    
    public string CodigoPaciente { get; set; }
    
    public string CodigoDocumentoMedico { get; set; }
    
    public int ConsultaCodigo { get; set; }
    
    public int IDAutorizacion { get; set; }

    [ForeignKey("NumSala")]
    public Sala Sala { get; set; }
    
    [ForeignKey("CodigoPaciente")]
    public PerfilUsuario Paciente { get; set; }
    
    [ForeignKey("CodigoDocumentoMedico")]
    public PerfilUsuario Medico { get; set; }
    
    [ForeignKey("ConsultaCodigo")]
    public Consulta Consulta { get; set; }
    
    [ForeignKey("IDAutorizacion")]
    public Autorizacion Autorizacion { get; set; }
}
