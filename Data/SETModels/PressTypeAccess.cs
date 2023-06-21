using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KSIMonitor.Data.SETModels {
    [Table("presstype_access"), Keyless]
    public partial class PressTypeAccess {
        [Column("vernr")]
        public int EventID { get; set; }
        [Column("accnr")]
        public int AccessID { get; set; }
        [Column("typeid")]
        public int TypeID { get; set; }
    }
}
