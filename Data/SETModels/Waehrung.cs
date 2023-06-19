using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KSIMonitor.Data.SETModels {
    [Table("waehrung")]
    public partial class Waehrung {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Required]
        [Column("bezeichnung")]
        [StringLength(10)]
        public string Bezeichnung { get; set; }
    }
}
