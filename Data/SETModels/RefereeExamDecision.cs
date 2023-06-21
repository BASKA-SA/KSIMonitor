using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KSIMonitor.Data.SETModels {
    [Table("referee_exam_decision"), Keyless]
    public partial class RefereeExamDecision {
        [Column("vernr")]
        public int EventID { get; set; }
        [Column("decision")]
        public int Decision { get; set; }
        [Column("refid")]
        public int Refid { get; set; }
        [Column("examid")]
        public int Examid { get; set; }
    }
}
