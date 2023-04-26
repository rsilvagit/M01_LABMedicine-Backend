using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using static m01_labMedicine.Core.Validation.CustomValidation;

namespace m01_labMedicine.DTO.Pessoa
{
    public abstract class PessoaDTO
    {
        [Required(ErrorMessage = "O Campo Nome � obrigat�rio")]
        [StringLength(maximumLength: 100)]
        public string Nome { get; set; }

        [StringLength(maximumLength: 30)]
        public string Genero { get; set; }

        [Required(ErrorMessage = "O Campo Data de nascimento � obrigat�rio")]
        [DataType(DataType.Date)]
        public DateTime DataNascimento { get; set; }
        [CheckCPF]
        public string CPF { get; set; }

        [AllowNull]
        [CheckTelefone]
        public string Telefone { get; set; }
    }
}