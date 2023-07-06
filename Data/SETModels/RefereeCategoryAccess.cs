using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KSIMonitor.Data.SETModels {
    [Table("refereecat_access"), Keyless]
    public partial class RefereeCategoryAccess {
        [Column("vernr")]
        public int EventID { get; set; }
        [Column("accnr")]
        public int AccessID { get; set; }
        [Column("ocid")]
        public int OcID { get; set; }
    }
}
