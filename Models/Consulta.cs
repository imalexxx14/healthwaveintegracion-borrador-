namespace Cuenta;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Consulta
{
    [Key]
    public int ConsultaCodigo { get; set; }
    
    [Required]
    public DateTime Fecha { get; set; }
    
    [Required]
    [MaxLength(50)]
    public string Estado { get; set; }
    
    [Column(TypeName = "decimal(10, 2)")]
    public decimal Costo { get; set; }
    
    [MaxLength(200)]
    public string Motivo { get; set; }
    
    [MaxLength(200)]
    public string Descripcion { get; set; }
    
    public string CodigoPaciente { get; set; }
    
    public string DocumentoMedico { get; set; }
    
    public int IDConsultorio { get; set; }
    
    public int IDAutorizacion { get; set; }

    [ForeignKey("CodigoPaciente")]
    public PerfilUsuario Paciente { get; set; }
    
    [ForeignKey("IDConsultorio")]
    public Consultorio Consultorio { get; set; }
    
    [ForeignKey("IDAutorizacion")]
    public Autorizacion Autorizacion { get; set; }
}
}