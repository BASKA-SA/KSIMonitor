using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KSIMonitor.Data.SETModels {
    [Table("patter_match")]
    public partial class PatterMatch {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Required]
        [Column("title")]
        [StringLength(255)]
        public string Title { get; set; }
        [Required]
        [Column("regexstring")]
        [StringLength(255)]
        public string Regexstring { get; set; }
        [Column("vernr")]
        public int Vernr { get; set; }
        [Required]
        [Column("kata", TypeName = "text")]
        public string Kata { get; set; }
    }
}
