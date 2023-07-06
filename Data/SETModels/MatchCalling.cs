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
        public int MatchNumber { get; set; }
        [Column("catid")]
        public int CategoryID { get; set; }
        [Column("pool")]
        public int Pool { get; set; }
        [Column("fieldpos")]
        public int FieldPos { get; set; }
        [Column("fieldposold")]
        public int FieldPosOld { get; set; }
        [Column("round")]
        public int Round { get; set; }
        [Column("catmatchnumber")]
        public int? CategoryMatchNumber { get; set; }
        [Column("tabletype")]
        public int TableType { get; set; }
        [Column("callmatch")]
        public int CallMatch { get; set; }
        [Column("callmatch2")]
        public int? CallMatch2 { get; set; }
        [Column("hidematch")]
        public int HideMatch { get; set; }
        [Column("calltime", TypeName = "timestamp")]
        public DateTime? CallTime { get; set; }
        [Column("calltime2", TypeName = "timestamp")]
        public DateTime? CallTime2 { get; set; }
        [Column("showuptime", TypeName = "timestamp")]
        public DateTime? ShowUpTime { get; set; }
        [Column("showuptime2", TypeName = "timestamp")]
        public DateTime? ShowUpTime2 { get; set; }
        [Column("name1", TypeName = "text")]
        public string Name1 { get; set; }
        [Column("name2", TypeName = "text")]
        public string Name2 { get; set; }
        [Column("matchnumber_show")]
        public int? MatchNumberShow { get; set; }
        [Column("ring")]
        public int? Ring { get; set; }
        [Column("winner")]
        public int? Winner { get; set; }
        [Column("winner_by"), StringLength(15)]
        public string WinnerBy { get; set; }
        [Column("result"), StringLength(15)]
        public string Result { get; set; }
        [Column("matchfromprinted")]
        public int MatchFromPrinted { get; set; }
    }
}
