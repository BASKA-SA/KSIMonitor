using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KSIMonitor.Data.SETModels {
    [Table("kata")]
    public partial class Katum {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Required]
        [Column("bezeichnung")]
        [StringLength(255)]
        public string Bezeichnung { get; set; }
        [Column("stilnr")]
        public int Stilnr { get; set; }
    }
}
