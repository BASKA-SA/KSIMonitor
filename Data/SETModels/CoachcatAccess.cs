using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KSIMonitor.Data.SETModels {
    [Table("coachcat_access"), Keyless]
    public partial class CoachcatAccess {
        [Column("vernr")]
        public int Vernr { get; set; }
        [Column("accnr")]
        public int Accnr { get; set; }
        [Column("ocid")]
        public int OcID { get; set; }
    }
}
