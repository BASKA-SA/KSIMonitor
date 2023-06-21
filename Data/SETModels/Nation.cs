using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KSIMonitor.Data.SETModels {
    [Table("nation")]
    public partial class Nation {
        [Column("id"), Key]
        public int ID { get; set; }
        [Column("bezeichnung"), Required, StringLength(255)]
        public string Name { get; set; }
        [Column("iso"), Required, StringLength(5)]
        public string ISO { get; set; }
        [Column("kurz"), StringLength(15)]
        public string Kurz { get; set; }
        [Column("lat"), StringLength(50)]
        public string Lat { get; set; }
        [Column("lon"), StringLength(50)]
        public string Lon { get; set; }
        [Column("extid")]
        public int? ExtID { get; set; }
        [Column("hide")]
        public int? Hide { get; set; }
    }
}
