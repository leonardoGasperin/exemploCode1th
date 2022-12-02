using System.ComponentModel.DataAnnotations.Schema;

namespace M2S10API.Models
{
    [Table("Turma")]
    public class Class
    {
        public int Id { get; set; }

        [ForeignKey("Instructor"), Column("Id Instrutor")]
        public int IdInstructor { get; set; }

        [ForeignKey("Course"), Column("Id Curso")]
        public int idCourse { get; set; }

        [Column("Data de início")]
        public DateTime? StartDate { get; set; }

        [Column("Data de término")]
        public DateTime? EndDate { get; set; }

        [Column("Carga Horária")]
        public int? Workload { get; set; }

        public Instructor Instructor { get; set; }
        public Course Course { get; set; }
    }
}
