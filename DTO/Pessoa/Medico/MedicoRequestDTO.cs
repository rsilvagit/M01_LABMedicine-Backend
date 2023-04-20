using System.ComponentModel.DataAnnotations;
using static m01_labMedicine.Validation.CustomValidation;

namespace m01_labMedicine.DTO.Pessoa.Medico
{
    public class MedicoRequestDTO : PessoaDTO
    {
        [Required]
        [StringLength(maximumLength: 250)]
        public string InstituicaoEnsino { get; set; }
        [Required]
        [StringLength(maximumLength: 20)]
        public string CRMUF { get; set; }
        [Required]
        [CheckEspecializacaoClinica(AllowEspecializacoes = "Cl�nico Geral,Anestesista,Dermatologia,Ginecologia,Neurologia,Pediatria,Psiquiatria,Ortopedia")]
        public string EspecializacaoClinica { get; set; }
        [Required]
        [checkSituacao(AllowSituacoes = "Ativo,Inativo")]
        public string SituacaoSistema { get; set; }
        public int TotalAtendimentos { get; set; }
    }
}