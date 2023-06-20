using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KSIMonitor.Data.SETModels {
    [Table("team_warteliste"),Keyless]
    public partial class TeamWarteliste {
        [Column("teamid")]
        public int TeamID { get; set; }
        [Column("nnr")]
        public int Nnr { get; set; }
    }
}
