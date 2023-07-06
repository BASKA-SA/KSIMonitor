using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KSIMonitor.Data.SETModels {
    [Table("exam")]
    public partial class Exam {
        [Column("vernr")]
        public int EventID { get; set; }
        [Column("id"), Key]
        public int ID { get; set; }
        [Column("title"), Required, StringLength(255)]
        public string Title { get; set; }
        [Column("theoreticalexam")]
        public int TheoreticalExam { get; set; }
        [Column("tewronganswers", TypeName = "text")]
        public string TeWrongAnswers { get; set; }
        [Column("tepercentage")]
        public int? TePercentage { get; set; }
        [Column("practicalexam")]
        public int PracticalExam { get; set; }
        [Column("pecriterias", TypeName = "text")]
        public string PeCriterias { get; set; }
        [Column("pecriteriasmax")]
        public int? PeCriteriasMax { get; set; }
        [Column("passmark")]
        public int PassMark { get; set; }
    }
}
