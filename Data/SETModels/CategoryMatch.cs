using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KSIMonitor.Data.SETModels {
    [Table("category_match")]
    public partial class CategoryMatch {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Required]
        [Column("title")]
        [StringLength(255)]
        public string Title { get; set; }
        [Column("vernr")]
        public int Vernr { get; set; }
        [Required]
        [Column("category", TypeName = "text")]
        public string Category { get; set; }
    }
}
