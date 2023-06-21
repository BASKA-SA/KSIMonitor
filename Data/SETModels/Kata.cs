using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KSIMonitor.Data.SETModels {
    [Table("kata")]
    public partial class Kata {
        [Column("id"), Key]
        public int ID { get; set; }
        [Column("bezeichnung"), Required, StringLength(255)]
        public string Name { get; set; }
        [Column("stilnr")]
        public int Stilnr { get; set; }
    }
}
