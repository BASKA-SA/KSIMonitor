using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KSIMonitor.Data.SETModels {
    [Table("match_calling"), Keyless]
    public partial class MatchCalling {
        [Column("eventid")]
        public int EventID { get; set; }
        [Column("matchnumber")]
        public int Matchnumber { get; set; }
        [Column("catid")]
        public int CatID { get; set; }
        [Column("pool")]
        public int Pool { get; set; }
        [Column("fieldpos")]
        public int Fieldpos { get; set; }
        [Column("fieldposold")]
        public int Fieldposold { get; set; }
        [Column("round")]
        public int Round { get; set; }
        [Column("catmatchnumber")]
        public int? Catmatchnumber { get; set; }
        [Column("tabletype")]
        public int Tabletype { get; set; }
        [Column("callmatch")]
        public int Callmatch { get; set; }
        [Column("hidematch")]
        public int Hidematch { get; set; }
        [Column("calltime", TypeName = "timestamp")]
        public DateTime? Calltime { get; set; }
        [Column("name1", TypeName = "text")]
        public string Name1 { get; set; }
        [Column("name2", TypeName = "text")]
        public string Name2 { get; set; }
        [Column("calltime2", TypeName = "timestamp")]
        public DateTime? Calltime2 { get; set; }
        [Column("callmatch2")]
        public int? Callmatch2 { get; set; }
        [Column("showuptime", TypeName = "timestamp")]
        public DateTime? Showuptime { get; set; }
        [Column("showuptime2", TypeName = "timestamp")]
        public DateTime? Showuptime2 { get; set; }
        [Column("matchnumber_show")]
        public int? MatchnumberShow { get; set; }
        [Column("ring")]
        public int? Ring { get; set; }
        [Column("winner")]
        public int? Winner { get; set; }
        [Column("winner_by"), StringLength(15)]
        public string WinnerBy { get; set; }
        [Column("result"), StringLength(15)]
        public string Result { get; set; }
        [Column("matchfromprinted")]
        public int Matchfromprinted { get; set; }
    }
}
