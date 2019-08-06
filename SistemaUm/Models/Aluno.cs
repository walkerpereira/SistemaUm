using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaUm.Models
{
    [Table("ALUNO")]
    public class Aluno
    {
        [Key]
        [Column("ID_ALUNO")]
        public int AlunoId { get; set; }
        [Column("NM_NOME")]
        public string Nome { get; set; }
    }
}
