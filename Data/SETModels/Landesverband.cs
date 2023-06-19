using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KSIMonitor.Data.SETModels {
    [Table("landesverband")]
    public partial class Landesverband {
        [Column("id"), Key]
        public int ID { get; set; }
        [Column("nationnr")]
        public int Nationnr { get; set; }
        [Column("bezeichnung"), Required, StringLength(255)]
        public string Bezeichnung { get; set; }
        [Column("kurz"), StringLength(20)]
        public string Kurz { get; set; }
        [Column("natid"), StringLength(7)]
        public string NatID { get; set; }
        [Column("extid")]
        public int? ExtID { get; set; }
    }
}
