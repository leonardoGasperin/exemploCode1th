using System.ComponentModel.DataAnnotations.Schema;

namespace M2S10API.Models
{
    [Table("Matricula")]
    public class Register
    {
        public int Id { get; set; }

        [ForeignKey("Class"), Column("IdTurma")]
        public int IdClass { get; set; }

        [ForeignKey("Student"), Column("IdAluno")]
        public int IdStudent { get; set; }

        [Column("DataMatricula")]
        public DateTime? RegisterDate { get; set; }

        public Class Class { get; set; }
        public Student Student { get; set; }
    }
}
