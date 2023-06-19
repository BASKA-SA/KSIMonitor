using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KSIMonitor.Data.SETModels {
    [Keyless]
    [Table("referee_matcharea")]
    public partial class RefereeMatcharea {
        [Column("vernr")]
        public int Vernr { get; set; }
        [Column("refid")]
        public int? Refid { get; set; }
        [Column("area")]
        public int? Area { get; set; }
    }
}
