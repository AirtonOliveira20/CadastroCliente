using System.ComponentModel.DataAnnotations;

namespace CadastroCliente2.Model
{
    public class Cliente
    {
        
        public int Id { get; set; }

        [Required]
        public String Nome { get; set; }

        [Required]
        public String EstadoCivil { get; set; }

        [Required]
        [RegularExpression(@"^\d{3}\.\d{3}\.\d{3}-\d{2}$", ErrorMessage = "CPF inválido.")]
        public String CPF { get; set; }

        [Required]
        [EmailAddress]
        public String Email { get; set; }

        [Required]
        public DateTime DtNascimento { get; set; }


    }
}
