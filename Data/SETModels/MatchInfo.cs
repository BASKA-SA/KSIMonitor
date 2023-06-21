using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KSIMonitor.Data.SETModels {
    [Table("matchinfo"), Keyless]
    public partial class MatchInfo {
        [Column("matchid"), StringLength(255)]
        public string MatchID { get; set; }
        [Column("matchinfo", TypeName = "text")]
        public string Info { get; set; }
    }
}
