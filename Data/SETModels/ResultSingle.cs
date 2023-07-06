using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KSIMonitor.Data.SETModels {
    [Table("ergebniseinzel"), Keyless]
    public partial class ResultSingle {
        [Column("vernr")]
        public int EventID { get; set; }
        [Column("knr")]
        public int CategoryID { get; set; }
        [Column("nnr")]
        public int NameID { get; set; }
        [Column("erg")]
        public int Result { get; set; }
        [Column("done")]
        public int? Done { get; set; }
        [Column("ergreal")]
        public int ResultReal { get; set; }
        [Column("comment"), StringLength(255)]
        public string Comment { get; set; }
    }
}
