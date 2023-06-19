using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KSIMonitor.Data.SETModels {
    [Table("patter_match")]
    public partial class PatterMatch {
        [Column("id"), Key]
        public int ID { get; set; }
        [Column("title"), Required, StringLength(255)]
        public string Title { get; set; }
        [Column("regexstring"), Required, StringLength(255)]
        public string Regexstring { get; set; }
        [Column("vernr")]
        public int Vernr { get; set; }
        [Column("kata", TypeName = "text"), Required]
        public string Kata { get; set; }
    }
}
