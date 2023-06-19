using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KSIMonitor.Data.SETModels {
    [Table("category_match")]
    public partial class CategoryMatch {
        [Column("id"), Key]
        public int Id { get; set; }
        [Column("title"), Required, StringLength(255)]
        public string Title { get; set; }
        [Column("vernr")]
        public int Vernr { get; set; }
        [Column("category", TypeName = "text"), Required]
        public string Category { get; set; }
    }
}
