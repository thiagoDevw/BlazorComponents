using System.ComponentModel.DataAnnotations;

namespace BlazorComponent.Models
{
    public class Medico
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Nome deve ser fornecido")]
        [MinLength(3, ErrorMessage = "Nome deve conter no mínimo 3 caracteres")]
        [MaxLength(50, ErrorMessage = "Nome deve conter no máximo caracteres")]
        public string Name { get; set; }

        [Required(ErrorMessage = "CRM deve ser fornecido")]
        public string Crm { get; set; }
    }
}
