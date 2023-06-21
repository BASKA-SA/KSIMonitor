using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KSIMonitor.Data.SETModels {
    [Table("ergebnisteam"), Keyless]
    public partial class ResultTeam {
        [Column("vernr")]
        public int EventID { get; set; }
        [Column("knr")]
        public int CategoryID { get; set; }
        [Column("vereinnr")]
        public int AssociationID { get; set; }
        [Column("mannschaft", TypeName = "text"), Required]
        public string Mannschaft { get; set; }
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
