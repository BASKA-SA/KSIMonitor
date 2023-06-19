using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KSIMonitor.Data.SETModels {
    [Keyless]
    [Table("ergebnisteam")]
    public partial class Ergebnisteam {
        [Column("vernr")]
        public int Vernr { get; set; }
        [Column("knr")]
        public int Knr { get; set; }
        [Column("vereinnr")]
        public int Vereinnr { get; set; }
        [Required]
        [Column("mannschaft", TypeName = "text")]
        public string Mannschaft { get; set; }
        [Column("erg")]
        public int Erg { get; set; }
        [Column("done")]
        public int? Done { get; set; }
        [Column("ergreal")]
        public int Ergreal { get; set; }
        [Column("comment")]
        [StringLength(255)]
        public string Comment { get; set; }
    }
}
