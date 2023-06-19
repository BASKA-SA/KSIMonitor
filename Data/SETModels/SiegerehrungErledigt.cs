using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KSIMonitor.Data.SETModels {
    [Keyless]
    [Table("siegerehrung_erledigt")]
    public partial class SiegerehrungErledigt {
        [Column("vernr")]
        public int Vernr { get; set; }
        [Column("knr")]
        public int Knr { get; set; }
    }
}
