using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KSIMonitor.Data.SETModels {
    [Table("referee")]
    public partial class Referee {
        [Column("id"), Key]
        public int ID { get; set; }
        [Column("titel"), StringLength(50)]
        public string Title { get; set; }
        [Column("vorname"), Required, StringLength(255)]
        public string FirstName { get; set; }
        [Column("nachname"), Required, StringLength(255)]
        public string LastName { get; set; }
        [Column("geburt", TypeName = "date")]
        public DateTime BirthDate { get; set; }
        [Column("sichtbar")]
        public int Visible { get; set; }
        [Column("kyu")]
        public int? Kyu { get; set; }
        [Column("dan")]
        public int? Dan { get; set; }
        [Column("lizenznat", TypeName = "text")]
        public string Licensed { get; set; }
        [Column("geschlecht"), Required, StringLength(1)]
        public string Gender { get; set; }
        [Column("vereinnr")]
        public int AssociationID { get; set; }
        [Column("nationnr")]
        public int? NationID { get; set; }
        [Column("lizenzint", TypeName = "text")]
        public string LicenceInt { get; set; }
        [Column("lizenznr"), StringLength(255)]
        public string LicenceID { get; set; }
        [Column("email"), StringLength(255)]
        public string Email { get; set; }
        [Column("wkfid"), StringLength(100)]
        public string WKFID { get; set; }
        [Column("passportid"), StringLength(50)]
        public string PassportID { get; set; }
        [Column("extid"), StringLength(30)]
        public string ExtID { get; set; }
        [Column("exthasprivatecomment")]
        public int? ExtHasPrivateComment { get; set; }
        [Column("exthaspubliccomment")]
        public int? ExtHasPublicComment { get; set; }
        [Column("puuid"), StringLength(50)]
        public string PuuID { get; set; }
        [Column("datafield1"), StringLength(255)]
        public string DataField1 { get; set; }
        [Column("datafield2"), StringLength(255)]
        public string DataField2 { get; set; }
        [Column("datafield3"), StringLength(255)]
        public string DataField3 { get; set; }
        [Column("datafield4"), StringLength(255)]
        public string DataField4 { get; set; }
        [Column("datafield5"), StringLength(255)]
        public string DataField5 { get; set; }
        [Column("datafield6"), StringLength(255)]
        public string DataField6 { get; set; }
        [Column("datafield7"), StringLength(255)]
        public string DataField7 { get; set; }
        [Column("datafield8"), StringLength(255)]
        public string DataField8 { get; set; }
        [Column("datafield9"), StringLength(255)]
        public string DataField9 { get; set; }
        [Column("datafield10"), StringLength(255)]
        public string DataField10 { get; set; }
    }
}
