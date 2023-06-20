using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KSIMonitor.Data.SETModels {
    [Table("wintype")]
    public partial class Wintype {
        [Column("id"), Key]
        public int ID { get; set; }
        [Column("title"), Required, StringLength(100)]
        public string Title { get; set; }
        [Column("short"), Required, StringLength(100)]
        public string Short { get; set; }
        [Column("sport")]
        public int Sport { get; set; }
    }
}
