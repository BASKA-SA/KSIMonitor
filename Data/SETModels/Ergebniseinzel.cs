using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KSIMonitor.Data.SETModels {
    [Table("ergebniseinzel"), Keyless]
    public partial class Ergebniseinzel {
        [Column("vernr")]
        public int Vernr { get; set; }
        [Column("knr")]
        public int Knr { get; set; }
        [Column("nnr")]
        public int Nnr { get; set; }
        [Column("erg")]
        public int Erg { get; set; }
        [Column("done")]
        public int? Done { get; set; }
        [Column("ergreal")]
        public int Ergreal { get; set; }
        [Column("comment"), StringLength(255)]
        public string Comment { get; set; }
    }
}
