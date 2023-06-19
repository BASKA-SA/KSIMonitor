using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KSIMonitor.Data.SETModels {
    [Table("press_registration")]
    public partial class PressRegistration {
        [Key]
        [Column("id")]
        public uint Id { get; set; }
        [Required]
        [Column("firstname")]
        [StringLength(150)]
        public string Firstname { get; set; }
        [Required]
        [Column("lastname")]
        [StringLength(150)]
        public string Lastname { get; set; }
        [Required]
        [Column("medianame")]
        [StringLength(255)]
        public string Medianame { get; set; }
        [Column("type")]
        public int Type { get; set; }
        [Column("othertype")]
        [StringLength(150)]
        public string Othertype { get; set; }
        [Column("functionname")]
        public int Functionname { get; set; }
        [Column("otherfunction")]
        [StringLength(255)]
        public string Otherfunction { get; set; }
        [Column("pressid")]
        [StringLength(150)]
        public string Pressid { get; set; }
        [Required]
        [Column("email")]
        [StringLength(255)]
        public string Email { get; set; }
        [Column("phone")]
        [StringLength(100)]
        public string Phone { get; set; }
        [Column("mobile")]
        [StringLength(100)]
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
        [Column("acccustom")]
        [StringLength(255)]
        public string Acccustom { get; set; }
    }
}
