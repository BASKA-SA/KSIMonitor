using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KSIMonitor.Data.SETModels {
    [Table("veranstaltung_area"), Keyless]
    public partial class EventArea {
        [Column("vernr")]
        public int EventID { get; set; }
        [Column("accnr")]
        public int AccessID { get; set; }
        [Column("nr")]
        public int? ID { get; set; }
        [Column("kurzbez"), Required, StringLength(5)]
        public string Kurzbez { get; set; }
        [Column("athletesallowed")]
        public int? AthletesAllowed { get; set; }
        [Column("coachesallowed")]
        public int? CoachesAllowed { get; set; }
        [Column("coachcatsallowed")]
        public int? CoachCategoriesAllowed { get; set; }
        [Column("refereesallowed")]
        public int? RefereesAllowed { get; set; }
        [Column("refereecatsallowed")]
        public int? RefereeCategoriesAllowed { get; set; }
        [Column("officialsallowed")]
        public int? OfficialsAllowed { get; set; }
        [Column("offcatsallowed")]
        public int? OfficialCategoriesAllowed { get; set; }
        [Column("pressallowed")]
        public int? PressAllowed { get; set; }
        [Column("presstypeallowed")]
        public int? PressTypeAllowed { get; set; }
    }
}
