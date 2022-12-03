using System.ComponentModel.DataAnnotations.Schema;

namespace M2S10API.Models
{
    [Table("Turma")]
    public class Class
    {
        public int Id { get; set; }

        [ForeignKey("Instructor"), Column("IdInstrutor")]
        public int IdInstructor { get; set; }

        [ForeignKey("Course"), Column("IdCurso")]
        public int IdCourse { get; set; }

        [Column("Datainicio")]
        public DateTime? StartDate { get; set; }

        [Column("Datatermino")]
        public DateTime? EndDate { get; set; }

        [Column("CargaHoraria")]
        public int? Workload { get; set; }

        public Instructor Instructor { get; set; }
        public Course Course { get; set; }
    }
}
