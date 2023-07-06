using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KSIMonitor.Data.SETModels {
    [Table("referee_exam_result"), Keyless]
    public partial class RefereeExamResult {
        [Column("vernr")]
        public int EventID { get; set; }
        [Column("examid")]
        public int ExamID { get; set; }
        [Column("examinerid")]
        public int ExaminerID { get; set; }
        [Column("refid")]
        public int RefereeID { get; set; }
        [Column("type")]
        public int Type { get; set; }
        [Column("tewronganswers")]
        public int TeWrongAnswers { get; set; }
        [Column("pecriteriapoints", TypeName = "text")]
        public string PeCriteriaPoints { get; set; }
    }
}
