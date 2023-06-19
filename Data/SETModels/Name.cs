using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KSIMonitor.Data.SETModels {
    [Table("names")]
    public partial class Name {
        [Key]
        [Column("nnr")]
        public int Nnr { get; set; }
        [Required]
        [Column("name")]
        [StringLength(255)]
        public string Name1 { get; set; }
        [Column("geburt", TypeName = "date")]
        public DateTime Geburt { get; set; }
        [Column("vereinnr")]
        public int Vereinnr { get; set; }
        [Column("geschlecht")]
        [StringLength(1)]
        public string Geschlecht { get; set; }
        [Column("gewicht")]
        public int? Gewicht { get; set; }
        [Column("groesse")]
        public int? Groesse { get; set; }
        [Column("sichtbar")]
        public uint Sichtbar { get; set; }
        [Column("kyu")]
        public int? Kyu { get; set; }
        [Column("dan")]
        public int? Dan { get; set; }
        [Column("nationnr")]
        public int? Nationnr { get; set; }
        [Column("stpktnr")]
        public int? Stpktnr { get; set; }
        [Column("nationalid")]
        [StringLength(30)]
        public string Nationalid { get; set; }
        [Column("email")]
        [StringLength(255)]
        public string Email { get; set; }
        [Column("sonstiges", TypeName = "text")]
        public string Sonstiges { get; set; }
        [Column("wkfid")]
        [StringLength(100)]
        public string Wkfid { get; set; }
        [Column("passportid")]
        [StringLength(50)]
        public string Passportid { get; set; }
        [Column("extid")]
        [StringLength(30)]
        public string Extid { get; set; }
        [Column("exthasprivatecomment")]
        public int? Exthasprivatecomment { get; set; }
        [Column("exthaspubliccomment")]
        public int? Exthaspubliccomment { get; set; }
        [Column("puuid")]
        [StringLength(50)]
        public string Puuid { get; set; }
        [Column("exttype")]
        [StringLength(50)]
        public string Exttype { get; set; }
        [Column("isnohuman")]
        public int? Isnohuman { get; set; }
        [Column("datafield1")]
        [StringLength(255)]
        public string Datafield1 { get; set; }
        [Column("datafield2")]
        [StringLength(255)]
        public string Datafield2 { get; set; }
        [Column("datafield3")]
        [StringLength(255)]
        public string Datafield3 { get; set; }
        [Column("datafield4")]
        [StringLength(255)]
        public string Datafield4 { get; set; }
        [Column("datafield5")]
        [StringLength(255)]
        public string Datafield5 { get; set; }
        [Column("datafield6")]
        [StringLength(255)]
        public string Datafield6 { get; set; }
        [Column("datafield7")]
        [StringLength(255)]
        public string Datafield7 { get; set; }
        [Column("datafield8")]
        [StringLength(255)]
        public string Datafield8 { get; set; }
        [Column("datafield9")]
        [StringLength(255)]
        public string Datafield9 { get; set; }
        [Column("datafield10")]
        [StringLength(255)]
        public string Datafield10 { get; set; }
        [Column("accountenabled")]
        public int? Accountenabled { get; set; }
        [Column("accountusername")]
        [StringLength(50)]
        public string Accountusername { get; set; }
        [Column("accountpassword")]
        [StringLength(50)]
        public string Accountpassword { get; set; }
        [Column("classecanesdehoopers")]
        [StringLength(255)]
        public string Classecanesdehoopers { get; set; }
    }
}
