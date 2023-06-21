using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KSIMonitor.Data.SETModels {
    [Table("veranstaltung_limitbasedoncompetitors"), Keyless]
    public partial class EventLimitBasedOnCompetitor {
        [Column("veranstaltung_id")]
        public int VeranstaltungID { get; set; }
        [Column("person_type")]
        public int PersonType { get; set; }
        [Column("limitrule", TypeName = "text"), Required]
        public string Limitrule { get; set; }
    }
}
