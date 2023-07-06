using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KSIMonitor.Data.SETModels {
    [Table("kategorie")]
    public partial class Category {
        [Column("knr"), Key]
        public int CategoryID { get; set; }
        [Column("katbez"), Required, StringLength(255)]
        public string Katbez { get; set; }
        [Column("alterVon")]
        public int AgeFrom { get; set; }
        [Column("alternichtmehr")]
        public int AgeNotMoreThan { get; set; }
        [Column("geschlecht"), StringLength(1)]
        public string Gender { get; set; }
        [Column("team"), StringLength(1)]
        public string Team { get; set; }
        [Column("sportart")]
        public int? SportArt { get; set; }
        [Column("typ")]
        public int Type { get; set; }
    }
}
