using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace _2TDSPJ.API.Persitence.Models
{
    public class Turma
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TurmaId { get; set; }

        [Required(ErrorMessage = "Campo não pode ser nulo")]
        public string Sigla { get; set; }

       
        public string Sala { get; set; }

        [Required]
        public bool Ativo { get; set; }
    }
}
