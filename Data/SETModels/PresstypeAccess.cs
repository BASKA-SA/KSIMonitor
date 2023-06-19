using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KSIMonitor.Data.SETModels {
    [Keyless]
    [Table("presstype_access")]
    public partial class PresstypeAccess {
        [Column("vernr")]
        public int Vernr { get; set; }
        [Column("accnr")]
        public int Accnr { get; set; }
        [Column("typeid")]
        public int Typeid { get; set; }
    }
}
