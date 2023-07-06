using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KSIMonitor.Data.SETModels {
    [Table("nennungenofficial"), Keyless]
    public partial class EntryOfficial {
        [Column("id")]
        public int ID { get; set; }
        [Column("vernr")]
        public int EventID { get; set; }
        [Column("time", TypeName = "timestamp")]
        public DateTime Time { get; set; }
        [Column("registrator")]
        public int? Registrator { get; set; }
        [Column("daysinfo"), StringLength(50)]
        public string DaysInfo { get; set; }
        [Column("catid")]
        public int? CatID { get; set; }
        [Column("accprinted")]
        public int AccPrinted { get; set; }
        [Column("accprintedtime", TypeName = "timestamp")]
        public DateTime? AccPrintedTime { get; set; }
        [Column("acccustom"), StringLength(255)]
        public string AccCustom { get; set; }
        [Column("checkok")]
        public int? CheckOK { get; set; }
        [Column("checkok2")]
        public int? CheckOK2 { get; set; }
        [Column("checkcom", TypeName = "text")]
        public string CheckCom { get; set; }
        [Column("checkcom2", TypeName = "text")]
        public string CheckCom2 { get; set; }
        [Column("checkcom3", TypeName = "text")]
        public string CheckCom3 { get; set; }
    }
}
