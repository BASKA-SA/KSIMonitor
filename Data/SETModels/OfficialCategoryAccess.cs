using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KSIMonitor.Data.SETModels {
    [Table("officialcat_access"), Keyless]
    public partial class OfficialCategoryAccess {
        [Column("vernr")]
        public int EventID { get; set; }
        [Column("accnr")]
        public int AccessID { get; set; }
        [Column("ocid")]
        public int Ocid { get; set; }
    }
}
