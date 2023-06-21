using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KSIMonitor.Data.SETModels {
    [Table("siegerehrung_erledigt"), Keyless]
    public partial class AwardCeremonyCompleted {
        [Column("vernr")]
        public int EventID { get; set; }
        [Column("knr")]
        public int CategoryID { get; set; }
    }
}
