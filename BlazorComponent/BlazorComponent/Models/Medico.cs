using System.ComponentModel.DataAnnotations;

namespace BlazorComponent.Models
{
    public class Medico
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Nome deve ser fornecido")]
        [Range(3, 50, ErrorMessage = "CRM deve conter entre {0} e {1} caracteres")]
        public string Name { get; set; }

        [Required(ErrorMessage = "CRM deve ser fornecido")]
        public string Crm { get; set; }
    }
}
