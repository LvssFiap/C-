
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _2TDSPJ.API.Persitence.Models
{
    public class Aluno
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AlunoId { get; set; }

        [Required(ErrorMessage = "Campo não pode ser nulo")]
        public string Name { get; set; }

        [Required]
        public bool Ativo { get; set; }
    }
}
