using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KSIMonitor.Data.SETModels {
    [Keyless]
    [Table("sysparam")]
    public partial class Sysparam {
        [Column("param")]
        [StringLength(50)]
        public string Param { get; set; }
        [Column("value")]
        [StringLength(50)]
        public string Value { get; set; }
    }
}
