using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace M2S10API.Models
{
    [Table("Cursos")]
    public class Course
    {
        public int Id { get; set; }

        [StringLength(150), Column("Nome")]
        public string Name { get; set; }

        [StringLength(255), Column("Requisito")]
        public string? Requisite { get; set; }

        [Column("CargaHoraria")]
        public int? Workload { get; set; }

        [Column("Valor")]
        public decimal Cost { get; set; }
    }
}
