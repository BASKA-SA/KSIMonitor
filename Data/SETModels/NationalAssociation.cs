using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KSIMonitor.Data.SETModels {
    [Table("landesverband")]
    public partial class NationalAssociation {
        [Column("id"), Key]
        public int ID { get; set; }
        [Column("nationnr")]
        public int NationID { get; set; }
        [Column("bezeichnung"), Required, StringLength(255)]
        public string Name { get; set; }
        [Column("kurz"), StringLength(20)]
        public string Kurz { get; set; }
        [Column("natid"), StringLength(7)]
        public string NatID { get; set; }
        [Column("extid")]
        public int? ExtID { get; set; }
    }
}
