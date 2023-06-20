using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KSIMonitor.Data.SETModels {
    [Table("veranstaltung_compcount"), Keyless]
    public partial class VeranstaltungCompcount {
        [Column("vernr")]
        public int Vernr { get; set; }
        [Column("nnr")]
        public int Nnr { get; set; }
        [Column("eventcount")]
        public int Eventcount { get; set; }
    }
}
