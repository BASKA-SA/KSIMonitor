using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KSIMonitor.Data.SETModels {
    [Table("referee_exam_result"), Keyless]
    public partial class RefereeExamResult {
        [Column("vernr")]
        public int Vernr { get; set; }
        [Column("examid")]
        public int Examid { get; set; }
        [Column("tewronganswers")]
        public int Tewronganswers { get; set; }
        [Column("pecriteriapoints", TypeName = "text")]
        public string Pecriteriapoints { get; set; }
        [Column("examinerid")]
        public int Examinerid { get; set; }
        [Column("type")]
        public int Type { get; set; }
        [Column("refid")]
        public int Refid { get; set; }
    }
}
