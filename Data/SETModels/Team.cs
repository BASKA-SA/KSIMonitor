using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KSIMonitor.Data.SETModels {
    [Table("team"), Keyless]
    public partial class Team {
        [Column("teamid")]
        public int Teamid { get; set; }
        [Column("nnr")]
        public int Nnr { get; set; }
        [Column("checkokentry")]
        public int? Checkokentry { get; set; }
        [Column("checkcomentry", TypeName = "text")]
        public string Checkcomentry { get; set; }
        [Column("measurement")]
        public float? Measurement { get; set; }
        [Column("checkok")]
        public int? Checkok { get; set; }
        [Column("checkcom", TypeName = "text")]
        public string Checkcom { get; set; }
        [Column("accprinted")]
        public int Accprinted { get; set; }
        [Column("accprintedtime", TypeName = "timestamp")]
        public DateTime? Accprintedtime { get; set; }
        [Column("acccustom"), StringLength(255)]
        public string Acccustom { get; set; }
        [Column("checkokmedical")]
        public int? Checkokmedical { get; set; }
    }
}
