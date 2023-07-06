using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KSIMonitor.Data.SETModels {
    [Table("trostrunde_pool"), Keyless]
    public partial class RepechagePool {
        [Column("id")]
        public long ID { get; set; }
        [Column("vernr")]
        public int EventID { get; set; }
        [Column("knr")]
        public int CategoryID { get; set; }
        [Column("pool")]
        public int Pool { get; set; }
    }
}
