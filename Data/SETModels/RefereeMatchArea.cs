using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KSIMonitor.Data.SETModels {
    [Table("referee_matcharea"), Keyless]
    public partial class RefereeMatchArea {
        [Column("vernr")]
        public int EventID { get; set; }
        [Column("refid")]
        public int? RefereeID { get; set; }
        [Column("area")]
        public int? Area { get; set; }
    }
}
