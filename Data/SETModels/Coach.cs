using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KSIMonitor.Data.SETModels {
    [Table("coach")]
    public partial class Coach {
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
        [Column("sonstiges", TypeName = "text")]
        public string Misc { get; set; }
        [Column("geschlecht"), Required, StringLength(1)]
        public string Gender { get; set; }
        [Column("vereinnr")]
        public int AssociationID { get; set; }
        [Column("email"), StringLength(255)]
        public string Email { get; set; }
        [Column("wkfid"), StringLength(100)]
        public string WKFID { get; set; }
        [Column("passportid"), StringLength(50)]
        public string PassportID { get; set; }
        [Column("extid"), StringLength(30)]
        public string ExtID { get; set; }
        [Column("exthasprivatecomment")]
        public int? Exthasprivatecomment { get; set; }
        [Column("exthaspubliccomment")]
        public int? Exthaspubliccomment { get; set; }
        [Column("puuid"), StringLength(50)]
        public string PuuID { get; set; }
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
