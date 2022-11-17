using System.ComponentModel.DataAnnotations;

namespace TareasMVC.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "EL campo {0} es requerido")]
        [EmailAddress(ErrorMessage = "EL campo debe ser un correo electronico valido")]
        public string Email { get; set; }
        [Required(ErrorMessage = "EL campo {0} es requerido")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Display(Name = "Recuérdame")]        
        public bool Recuerdame { get; set; }
    }
}
