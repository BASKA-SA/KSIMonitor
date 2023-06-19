using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KSIMonitor.Data.SETModels {
    [Table("landesverband")]
    public partial class Landesverband {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("nationnr")]
        public int Nationnr { get; set; }
        [Required]
        [Column("bezeichnung")]
        [StringLength(255)]
        public string Bezeichnung { get; set; }
        [Column("kurz")]
        [StringLength(20)]
        public string Kurz { get; set; }
        [Column("natid")]
        [StringLength(7)]
        public string Natid { get; set; }
        [Column("extid")]
        public int? Extid { get; set; }
    }
}
