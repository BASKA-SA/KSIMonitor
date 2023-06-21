using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KSIMonitor.Data.SETModels {
    [Table("trostrunde_pool"), Keyless]
    public partial class RepechagePool {
        [Column("id")]
        public long Id { get; set; }
        [Column("vernr")]
        public int EventID { get; set; }
        [Column("knr")]
        public int CategoryID { get; set; }
        [Column("pool")]
        public int Pool { get; set; }
    }
}
