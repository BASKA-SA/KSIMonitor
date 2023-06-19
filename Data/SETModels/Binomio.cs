using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KSIMonitor.Data.SETModels {
    [Table("binomio")]
    public partial class Binomio {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("conduttore")]
        public int Conduttore { get; set; }
        [Column("cane")]
        public int Cane { get; set; }
        [Column("created", TypeName = "timestamp")]
        public DateTime Created { get; set; }
        [Column("clubid")]
        public int Clubid { get; set; }
        [Column("status")]
        public int Status { get; set; }
        [Column("rally")]
        [StringLength(255)]
        public string Rally { get; set; }
        [Column("kanito")]
        public int Kanito { get; set; }
        [Column("sichtbar")]
        public int Sichtbar { get; set; }
        [Column("gradosdsfreestyle")]
        [StringLength(50)]
        public string Gradosdsfreestyle { get; set; }
        [Column("gradosdsspeedwater")]
        [StringLength(50)]
        public string Gradosdsspeedwater { get; set; }
        [Column("gradosdssplashdog")]
        [StringLength(50)]
        public string Gradosdssplashdog { get; set; }
        [Column("gradosdsobedience")]
        [StringLength(50)]
        public string Gradosdsobedience { get; set; }
        [Column("gradosdshoopers")]
        [StringLength(50)]
        public string Gradosdshoopers { get; set; }
    }
}
