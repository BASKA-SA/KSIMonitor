using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KSIMonitor.Data.SETModels {
    [Table("nation")]
    public partial class Nation {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Required]
        [Column("bezeichnung")]
        [StringLength(255)]
        public string Bezeichnung { get; set; }
        [Required]
        [Column("iso")]
        [StringLength(5)]
        public string Iso { get; set; }
        [Column("kurz")]
        [StringLength(15)]
        public string Kurz { get; set; }
        [Column("lat")]
        [StringLength(50)]
        public string Lat { get; set; }
        [Column("lon")]
        [StringLength(50)]
        public string Lon { get; set; }
        [Column("extid")]
        public int? Extid { get; set; }
        [Column("hide")]
        public int? Hide { get; set; }
    }
}