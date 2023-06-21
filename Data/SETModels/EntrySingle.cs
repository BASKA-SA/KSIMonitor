using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KSIMonitor.Data.SETModels {
    [Table("nennungeneinzel"), Keyless]
    public partial class EntrySingle {
        [Column("vernr")]
        public int EventID { get; set; }
        [Column("katnr")]
        public int Katnr { get; set; }
        [Column("nnr")]
        public int NameID { get; set; }
        [Column("gesetzt")]
        public int? Gesetzt { get; set; }
        [Column("time", TypeName = "timestamp")]
        public DateTime Time { get; set; }
        [Column("registrator")]
        public int? Registrator { get; set; }
        [Column("checkok")]
        public int? Checkok { get; set; }
        [Column("checkcom", TypeName = "text")]
        public string Checkcom { get; set; }
        [Column("checkokentry")]
        public int? Checkokentry { get; set; }
        [Column("checkcomentry", TypeName = "text")]
        public string Checkcomentry { get; set; }
        [Column("measurement")]
        public float? Measurement { get; set; }
        [Column("accprinted")]
        public int Accprinted { get; set; }
        [Column("accprintedtime", TypeName = "timestamp")]
        public DateTime? Accprintedtime { get; set; }
        [Column("acccustom"), StringLength(255)]
        public string Acccustom { get; set; }
        [Column("regdob", TypeName = "date")]
        public DateTime? Regdob { get; set; }
        [Column("checkokmedical")]
        public int? Checkokmedical { get; set; }
    }
}
