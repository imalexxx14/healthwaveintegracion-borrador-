using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cuenta;

public class Cuenta
{
        [Key]
        public string IdUsuario { get; set; }
    
        [Required]
        [MaxLength(50)]
        public string NombreUsuario { get; set; }
    
        [Required]
        [MaxLength(255)]
        public string Contraseña { get; set; }
    
        public string CodigoDocumento { get; set; }
    
        [ForeignKey("CodigoDocumento")]
        public PerfilUsuario PerfilUsuario { get; set; }
    }

    
