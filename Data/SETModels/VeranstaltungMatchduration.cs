using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KSIMonitor.Data.SETModels {
    [Keyless]
    [Table("veranstaltung_matchduration")]
    public partial class VeranstaltungMatchduration {
        [Column("matchid")]
        [StringLength(100)]
        public string Matchid { get; set; }
        [Column("catid")]
        public int? Catid { get; set; }
        [Column("athleteid1")]
        public int? Athleteid1 { get; set; }
        [Column("athleteid2")]
        public int? Athleteid2 { get; set; }
        [Column("matchduration")]
        public int? Matchduration { get; set; }
        [Column("verid")]
        public int? Verid { get; set; }
    }
}
