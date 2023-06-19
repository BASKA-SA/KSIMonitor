using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KSIMonitor.Data.SETModels {
    [Table("exam")]
    public partial class Exam {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Required]
        [Column("title")]
        [StringLength(255)]
        public string Title { get; set; }
        [Column("theoreticalexam")]
        public int Theoreticalexam { get; set; }
        [Column("tewronganswers", TypeName = "text")]
        public string Tewronganswers { get; set; }
        [Column("practicalexam")]
        public int Practicalexam { get; set; }
        [Column("pecriterias", TypeName = "text")]
        public string Pecriterias { get; set; }
        [Column("tepercentage")]
        public int? Tepercentage { get; set; }
        [Column("passmark")]
        public int Passmark { get; set; }
        [Column("pecriteriasmax")]
        public int? Pecriteriasmax { get; set; }
        [Column("vernr")]
        public int Vernr { get; set; }
    }
}
