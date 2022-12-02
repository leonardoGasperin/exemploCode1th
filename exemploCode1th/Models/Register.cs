using System.ComponentModel.DataAnnotations.Schema;

namespace M2S10API.Models
{
    [Table("Matrícula")]
    public class Register
    {
        public int Id { get; set; }

        [ForeignKey("Class"), Column("Id Turma")]
        public int IdClass { get; set; }

        [ForeignKey("Student"), Column("Id Aluno")]
        public int IdStudant { get; set; }

        [Column("Data Matricula")]
        public DateTime? RegisterDate { get; set; }

        public Class Class { get; set; }
        public Student Student { get; set; }
    }
}
