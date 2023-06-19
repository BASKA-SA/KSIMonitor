using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KSIMonitor.Data.SETModels {
    [Table("referee")]
    public partial class Referee {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("titel")]
        [StringLength(50)]
        public string Titel { get; set; }
        [Required]
        [Column("vorname")]
        [StringLength(255)]
        public string Vorname { get; set; }
        [Required]
        [Column("nachname")]
        [StringLength(255)]
        public string Nachname { get; set; }
        [Column("geburt", TypeName = "date")]
        public DateTime Geburt { get; set; }
        [Column("sichtbar")]
        public int Sichtbar { get; set; }
        [Column("kyu")]
        public int? Kyu { get; set; }
        [Column("dan")]
        public int? Dan { get; set; }
        [Column("lizenznat", TypeName = "text")]
        public string Lizenznat { get; set; }
        [Required]
        [Column("geschlecht")]
        [StringLength(1)]
        public string Geschlecht { get; set; }
        [Column("vereinnr")]
        public int Vereinnr { get; set; }
        [Column("nationnr")]
        public int? Nationnr { get; set; }
        [Column("lizenzint", TypeName = "text")]
        public string Lizenzint { get; set; }
        [Column("lizenznr")]
        [StringLength(255)]
        public string Lizenznr { get; set; }
        [Column("email")]
        [StringLength(255)]
        public string Email { get; set; }
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
    }
}
