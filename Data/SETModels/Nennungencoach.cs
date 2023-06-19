using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KSIMonitor.Data.SETModels {
    [Keyless]
    [Table("nennungencoach")]
    public partial class Nennungencoach {
        [Column("id")]
        public int Id { get; set; }
        [Column("vernr")]
        public int Vernr { get; set; }
        [Column("time", TypeName = "timestamp")]
        public DateTime Time { get; set; }
        [Column("registrator")]
        public int? Registrator { get; set; }
        [Column("checkok")]
        public int? Checkok { get; set; }
        [Column("checkcom", TypeName = "text")]
        public string Checkcom { get; set; }
        [Column("catid")]
        public int? Catid { get; set; }
        [Column("accprinted")]
        public int Accprinted { get; set; }
        [Column("accprintedtime", TypeName = "timestamp")]
        public DateTime? Accprintedtime { get; set; }
        [Column("acccustom")]
        [StringLength(255)]
        public string Acccustom { get; set; }
        [Column("checkok2")]
        public int? Checkok2 { get; set; }
        [Column("checkcom2", TypeName = "text")]
        public string Checkcom2 { get; set; }
        [Column("checkcom3", TypeName = "text")]
        public string Checkcom3 { get; set; }
    }
}