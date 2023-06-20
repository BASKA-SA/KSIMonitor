using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KSIMonitor.Data.SETModels {
    [Table("veranstaltung_matchduration"), Keyless]
    public partial class VeranstaltungMatchduration {
        [Column("matchid"), StringLength(100)]
        public string MatchID { get; set; }
        [Column("catid")]
        public int? CatID { get; set; }
        [Column("athleteid1")]
        public int? AthleteID1 { get; set; }
        [Column("athleteid2")]
        public int? AthleteID2 { get; set; }
        [Column("matchduration")]
        public int? Matchduration { get; set; }
        [Column("verid")]
        public int? VerID { get; set; }
    }
}
