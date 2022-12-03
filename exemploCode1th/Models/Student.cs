using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace M2S10API.Models
{
    [Table("Estudante")]
    public class Student
    {
        public int Id { get; set; }

        [StringLength(15)]
        public string Cpf { get; set; }

        [StringLength(50), Column("Nome")]
        public string Name { get; set; }

        [StringLength(150), Column("E-mail")]
        public string Email { get; set; }

        [StringLength(14), Column("Telefone")]
        public string Phone { get; set; }

        [Column("DataNascimento")]
        public DateTime? BornDate { get; set; }
    }
}
