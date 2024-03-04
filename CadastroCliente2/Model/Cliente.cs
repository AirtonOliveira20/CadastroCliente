using System.ComponentModel.DataAnnotations;

namespace CadastroCliente2.Model
{
    public class Cliente
    {
        
        public int Id { get; set; }

        [Required]
        public String Nome { get; set; }

        [Required]
        public String CPF { get; set; }

        [Required]
        [EmailAddress]
        public String Email { get; set; }

        [Required]
        public DateTime DtNascimento { get; set; }


    }
}
