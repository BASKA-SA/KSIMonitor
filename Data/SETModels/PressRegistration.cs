using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KSIMonitor.Data.SETModels {
    [Table("press_registration")]
    public partial class PressRegistration {
        [Column("id"), Key]
        public uint ID { get; set; }
        [Column("firstname"), Required, StringLength(150)]
        public string FirstName { get; set; }
        [Column("lastname"), Required, StringLength(150)]
        public string LastName { get; set; }
        [Column("medianame"), Required, StringLength(255)]
        public string MediaName { get; set; }
        [Column("type")]
        public int Type { get; set; }
        [Column("othertype"), StringLength(150)]
        public string OtherType { get; set; }
        [Column("functionname")]
        public int FunctionName { get; set; }
        [Column("otherfunction"), StringLength(255)]
        public string OtherFunction { get; set; }
        [Column("pressid"), StringLength(150)]
        public string PressID { get; set; }
        [Column("email"), Required, StringLength(255)]
        public string Email { get; set; }
        [Column("phone"), StringLength(100)]
        public string Phone { get; set; }
        [Column("mobile"), StringLength(100)]
        public string Mobile { get; set; }
        [Column("countryid")]
        public int CountryID { get; set; }
        [Column("verid")]
        public int EventID { get; set; }
        [Column("regtime", TypeName = "timestamp")]
        public DateTime RegTime { get; set; }
        [Column("checkokentry")]
        public int? CheckOkEntry { get; set; }
        [Column("checkcomentry", TypeName = "text")]
        public string CheckComEntry { get; set; }
        [Column("accprinted")]
        public int AccPrinted { get; set; }
        [Column("accprintedtime", TypeName = "timestamp")]
        public DateTime? AccPrintedTime { get; set; }
        [Column("acccustom"), StringLength(255)]
        public string AccCustom { get; set; }
    }
}
