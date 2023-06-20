using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KSIMonitor.Data.SETModels {
    [Table("verein")]
    public partial class Verein {
        [Column("vereinnr"), Key]
        public uint Vereinnr { get; set; }
        [Column("bezeichnung"), Required, StringLength(255)]
        public string Bezeichnung { get; set; }
        [Column("nation")]
        public int Nation { get; set; }
        [Column("lvnr")]
        public int? Lvnr { get; set; }
        [Column("sektionnr")]
        public int? Sektionnr { get; set; }
        [Column("stpktnr")]
        public int? Stpktnr { get; set; }
        [Column("createdbymanager")]
        public int? Createdbymanager { get; set; }
        [Column("website"), StringLength(255)]
        public string Website { get; set; }
        [Column("nationalid"), StringLength(30)]
        public string NationalID { get; set; }
        [Column("extid"), StringLength(30)]
        public string ExtID { get; set; }
        [Column("puuid"), StringLength(50)]
        public string Puuid { get; set; }
        [Column("nataccountid"), StringLength(30)]
        public string NataccountID { get; set; }
        [Column("teamtype")]
        public int? Teamtype { get; set; }
        [Column("taxid"), StringLength(100)]
        public string TaxID { get; set; }
        [Column("address"), StringLength(255)]
        public string Address { get; set; }
        [Column("contact"), StringLength(255)]
        public string Contact { get; set; }
        [Column("phone"), StringLength(50)]
        public string Phone { get; set; }
        [Column("email"), StringLength(255)]
        public string Email { get; set; }
        [Column("datafield1"), StringLength(255)]
        public string Datafield1 { get; set; }
        [Column("datafield2"), StringLength(255)]
        public string Datafield2 { get; set; }
        [Column("datafield3"), StringLength(255)]
        public string Datafield3 { get; set; }
        [Column("datafield4"), StringLength(255)]
        public string Datafield4 { get; set; }
        [Column("datafield5"), StringLength(255)]
        public string Datafield5 { get; set; }
        [Column("datafield6"), StringLength(255)]
        public string Datafield6 { get; set; }
        [Column("datafield7"), StringLength(255)]
        public string Datafield7 { get; set; }
        [Column("datafield8"), StringLength(255)]
        public string Datafield8 { get; set; }
        [Column("datafield9"), StringLength(255)]
        public string Datafield9 { get; set; }
        [Column("datafield10"), StringLength(255)]
        public string Datafield10 { get; set; }
    }
}
