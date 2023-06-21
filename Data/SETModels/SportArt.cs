using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KSIMonitor.Data.SETModels {
    [Table("sportart")]
    public partial class SportArt {
        [Column("sportartnr"), Key]
        public uint SportArtID { get; set; }
        [Column("bezeichnung"), Required, StringLength(255)]
        public string Name { get; set; }
    }
}
