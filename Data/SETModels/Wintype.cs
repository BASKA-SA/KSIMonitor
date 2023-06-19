using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KSIMonitor.Data.SETModels {
    [Table("wintype")]
    public partial class Wintype {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Required]
        [Column("title")]
        [StringLength(100)]
        public string Title { get; set; }
        [Required]
        [Column("short")]
        [StringLength(100)]
        public string Short { get; set; }
        [Column("sport")]
        public int Sport { get; set; }
    }
}
