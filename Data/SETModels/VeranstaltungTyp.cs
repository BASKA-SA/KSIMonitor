using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KSIMonitor.Data.SETModels {
    [Table("veranstaltung_typ")]
    public partial class VeranstaltungTyp {
        [Column("id"), Key]
        public int ID { get; set; }
        [Column("bezeichnung"), Required, StringLength(255)]
        public string Bezeichnung { get; set; }
    }
}
