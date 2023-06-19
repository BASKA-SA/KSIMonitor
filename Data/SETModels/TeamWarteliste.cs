using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KSIMonitor.Data.SETModels {
    [Keyless]
    [Table("team_warteliste")]
    public partial class TeamWarteliste {
        [Column("teamid")]
        public int Teamid { get; set; }
        [Column("nnr")]
        public int Nnr { get; set; }
    }
}
