using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KSIMonitor.Data.SETModels {
    [Keyless]
    [Table("veranstaltung_limitbasedoncompetitors")]
    public partial class VeranstaltungLimitbasedoncompetitor {
        [Column("veranstaltung_id")]
        public int VeranstaltungId { get; set; }
        [Column("person_type")]
        public int PersonType { get; set; }
        [Required]
        [Column("limitrule", TypeName = "text")]
        public string Limitrule { get; set; }
    }
}
