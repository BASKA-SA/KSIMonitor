using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KSIMonitor.Data.SETModels {
    [Table("referee_exam"), Keyless]
    public partial class RefereeExam {
        [Column("vernr")]
        public int EventID { get; set; }
        [Column("refid")]
        public int RefereeID { get; set; }
        [Column("examid")]
        public int ExamID { get; set; }
        [Column("isexaminer")]
        public int IsExaminer { get; set; }
        [Column("eventcount")]
        public int? EventCount { get; set; }
    }
}
