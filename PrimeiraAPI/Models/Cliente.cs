using System.ComponentModel.DataAnnotations;

namespace PrimeiraAPI.Models
{
    public class Cliente
    {
        public Guid ClienteId { get; set; }
        [Required(ErrorMessage = "O nome do cliente é obrigatório.")]
        [Display(Name = "Nome do Cliente")]
        public string NomeCliente { get; set; }

        [Required(ErrorMessage = "O CPF do cliente é obrigatório.")]
        [Display(Name = "CPF do Cliente")]
        public string CpfCliente { get; set; }

        [Required(ErrorMessage = "O e-mail do cliente é obrigatório.")]
        [Display(Name = "Email do Cliente")]
        public string EmailCliente { get; set; }

    }
}
