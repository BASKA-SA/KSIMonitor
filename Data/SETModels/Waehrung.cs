using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KSIMonitor.Data.SETModels {
    [Table("waehrung")]
    public partial class Waehrung {
        [Column("id"), Key]
        public int Id { get; set; }
        [Column("bezeichnung"), Required, StringLength(10)]
        public string Bezeichnung { get; set; }
    }
}
