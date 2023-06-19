using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KSIMonitor.Data.SETModels {
    [Table("kategorie")]
    public partial class Kategorie {
        [Key]
        [Column("knr")]
        public int Knr { get; set; }
        [Required]
        [Column("katbez")]
        [StringLength(255)]
        public string Katbez { get; set; }
        [Column("alterVon")]
        public int AlterVon { get; set; }
        [Column("alternichtmehr")]
        public int Alternichtmehr { get; set; }
        [Column("geschlecht")]
        [StringLength(1)]
        public string Geschlecht { get; set; }
        [Column("team")]
        [StringLength(1)]
        public string Team { get; set; }
        [Column("sportart")]
        public int? Sportart { get; set; }
        [Column("typ")]
        public int Typ { get; set; }
    }
}
