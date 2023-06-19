using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KSIMonitor.Data.SETModels {
    [Table("press_registration")]
    public partial class PressRegistration {
        [Column("id"), Key]
        public uint ID { get; set; }
        [Column("firstname"), Required, StringLength(150)]
        public string Firstname { get; set; }
        [Column("lastname"), Required, StringLength(150)]
        public string Lastname { get; set; }
        [Column("medianame"), Required, StringLength(255)]
        public string Medianame { get; set; }
        [Column("type")]
        public int Type { get; set; }
        [Column("othertype"), StringLength(150)]
        public string Othertype { get; set; }
        [Column("functionname")]
        public int Functionname { get; set; }
        [Column("otherfunction"), StringLength(255)]
        public string Otherfunction { get; set; }
        [Column("pressid"), StringLength(150)]
        public string PressID { get; set; }
        [Column("email"), Required, StringLength(255)]
        public string Email { get; set; }
        [Column("phone"), StringLength(100)]
        public string Phone { get; set; }
        [Column("mobile"), StringLength(100)]
        public string Mobile { get; set; }
        [Column("countryid")]
        public int Countryid { get; set; }
        [Column("verid")]
        public int Verid { get; set; }
        [Column("regtime", TypeName = "timestamp")]
        public DateTime Regtime { get; set; }
        [Column("checkokentry")]
        public int? Checkokentry { get; set; }
        [Column("checkcomentry", TypeName = "text")]
        public string Checkcomentry { get; set; }
        [Column("accprinted")]
        public int Accprinted { get; set; }
        [Column("accprintedtime", TypeName = "timestamp")]
        public DateTime? Accprintedtime { get; set; }
        [Column("acccustom"), StringLength(255)]
        public string Acccustom { get; set; }
    }
}
