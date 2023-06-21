using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KSIMonitor.Data.SETModels {
    [Table("stilrichtung")]
    public partial class Style {
        [Column("id"), Key]
        public int ID { get; set; }
        [Column("bezeichnung"), Required, StringLength(255)]
        public string Name { get; set; }
    }
}
