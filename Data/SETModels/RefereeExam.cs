using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KSIMonitor.Data.SETModels {
    [Table("referee_exam"), Keyless]
    public partial class RefereeExam {
        [Column("vernr")]
        public int Vernr { get; set; }
        [Column("refid")]
        public int Refid { get; set; }
        [Column("examid")]
        public int Examid { get; set; }
        [Column("isexaminer")]
        public int Isexaminer { get; set; }
        [Column("eventcount")]
        public int? Eventcount { get; set; }
    }
}
