using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KSIMonitor.Data.SETModels {
    [Table("team"), Keyless]
    public partial class Team {
        [Column("teamid")]
        public int TeamID { get; set; }
        [Column("nnr")]
        public int NameID { get; set; }
        [Column("measurement")]
        public float? Measurement { get; set; }
        [Column("checkok")]
        public int? CheckOk { get; set; }
        [Column("checkokentry")]
        public int? CheckOkEntry { get; set; }
        [Column("checkcom", TypeName = "text")]
        public string CheckCom { get; set; }
        [Column("checkcomentry", TypeName = "text")]
        public string CheckComEntry { get; set; }
        [Column("checkokmedical")]
        public int? CheckOkMedical { get; set; }
        [Column("accprinted")]
        public int AccPrinted { get; set; }
        [Column("accprintedtime", TypeName = "timestamp")]
        public DateTime? AccPrintedTime { get; set; }
        [Column("acccustom"), StringLength(255)]
        public string AccCustom { get; set; }
    }
}
