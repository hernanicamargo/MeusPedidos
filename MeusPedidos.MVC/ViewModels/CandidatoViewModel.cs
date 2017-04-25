using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MeusPedidos.MVC.ViewModels
{
    public class CandidatoViewModel
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="Campo nome obrigatório")]
        [MaxLength(150,ErrorMessage ="Máximo {0} caracteres")]
        [MinLength(3,ErrorMessage ="Mínimo {0} caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Campo e-mail obrigatório")]
        [MaxLength(100, ErrorMessage = "Máximo {0} caracteres")]
        [EmailAddress(ErrorMessage ="Preencha um e-mail válido")]
        [DisplayName("E-mail")]
        public string Email { get; set; }
    }
}