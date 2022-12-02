using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace M2S10API.Models
{
    public class Instructor
    {
        public int Id { get; set; }

        [StringLength(150), Column("Nome")]
        public string Name { get; set; }

        [StringLength(150), Column("E-mail")]
        public string Email { get; set; }

        [StringLength(14), Column("Telefone")]
        public string Phone { get; set; }

        [Column("ValorHora")]
        public decimal? PayHour { get; set; }

        [StringLength(255), Column("Certificado")]
        public string? Certificate { get; set; }
    }
}
