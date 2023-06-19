using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KSIMonitor.Data.SETModels {
    [Table("matchinfo"), Keyless]
    public partial class Matchinfo {
        [Column("matchid"), StringLength(255)]
        public string Matchid { get; set; }
        [Column("matchinfo", TypeName = "text")]
        public string Matchinfo1 { get; set; }
    }
}
