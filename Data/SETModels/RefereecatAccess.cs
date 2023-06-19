using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KSIMonitor.Data.SETModels {
    [Keyless]
    [Table("refereecat_access")]
    public partial class RefereecatAccess {
        [Column("vernr")]
        public int Vernr { get; set; }
        [Column("accnr")]
        public int Accnr { get; set; }
        [Column("ocid")]
        public int Ocid { get; set; }
    }
}
