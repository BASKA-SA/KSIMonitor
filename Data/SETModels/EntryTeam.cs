using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KSIMonitor.Data.SETModels {
    [Table("nennungenteam"), Keyless, Index(nameof(TeamID), Name = "teamid", IsUnique = true)]
    public partial class EntryTeam {
        [Column("vernr")]
        public int EventID { get; set; }
        [Column("knr")]
        public int CategoryID { get; set; }
        [Column("vereinnr")]
        public int AssociationID { get; set; }
        [Required]
        [Column("mannschaft", TypeName = "text")]
        public string Team { get; set; }
        [Column("gesetzt")]
        public int? Gesetzt { get; set; }
        [Column("time", TypeName = "timestamp")]
        public DateTime Time { get; set; }
        [Column("registrator")]
        public int? Registrator { get; set; }
        [Column("teamid")]
        public int TeamID { get; set; }
    }
}
