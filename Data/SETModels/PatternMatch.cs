using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KSIMonitor.Data.SETModels {
    [Table("patter_match")]
    public partial class PatternMatch {
        [Column("id"), Key]
        public int ID { get; set; }
        [Column("title"), Required, StringLength(255)]
        public string Title { get; set; }
        [Column("regexstring"), Required, StringLength(255)]
        public string RegexString { get; set; }
        [Column("vernr")]
        public int EventID { get; set; }
        [Column("kata", TypeName = "text"), Required]
        public string Kata { get; set; }
    }
}
