using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KSIMonitor.Data.SETModels {
    [Table("veranstaltung_area"), Keyless]
    public partial class VeranstaltungArea {
        [Column("vernr")]
        public int Vernr { get; set; }
        [Column("accnr")]
        public int Accnr { get; set; }
        [Column("kurzbez"), Required, StringLength(5)]
        public string Kurzbez { get; set; }
        [Column("nr")]
        public int? Nr { get; set; }
        [Column("athletesallowed")]
        public int? Athletesallowed { get; set; }
        [Column("coachesallowed")]
        public int? Coachesallowed { get; set; }
        [Column("refereesallowed")]
        public int? Refereesallowed { get; set; }
        [Column("officialsallowed")]
        public int? Officialsallowed { get; set; }
        [Column("offcatsallowed")]
        public int? Offcatsallowed { get; set; }
        [Column("pressallowed")]
        public int? Pressallowed { get; set; }
        [Column("presstypeallowed")]
        public int? Presstypeallowed { get; set; }
        [Column("coachcatsallowed")]
        public int? Coachcatsallowed { get; set; }
        [Column("refereecatsallowed")]
        public int? Refereecatsallowed { get; set; }
    }
}
