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
        public int CategoryID { get; set; }
        [Column("nnr")]
        public int NameID { get; set; }
        [Column("gesetzt")]
        public int? Gesetzt { get; set; }
        [Column("time", TypeName = "timestamp")]
        public DateTime Time { get; set; }
        [Column("registrator")]
        public int? Registrator { get; set; }
        [Column("measurement")]
        public float? Measurement { get; set; }
        [Column("accprinted")]
        public int AccPrinted { get; set; }
        [Column("accprintedtime", TypeName = "timestamp")]
        public DateTime? AccPrintedTime { get; set; }
        [Column("acccustom"), StringLength(255)]
        public string AccCustom { get; set; }
        [Column("regdob", TypeName = "date")]
        public DateTime? RegDateOfBirth { get; set; }
        [Column("checkok")]
        public int? CheckOK { get; set; }
        [Column("checkokmedical")]
        public int? CheckOKMedical { get; set; }
        [Column("checkokentry")]
        public int? CheckOKEntry { get; set; }
        [Column("checkcom", TypeName = "text")]
        public string CheckCom { get; set; }
        [Column("checkcomentry", TypeName = "text")]
        public string CheckComEntry { get; set; }
    }
}
