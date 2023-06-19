using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KSIMonitor.Data.SETModels {
    [Keyless]
    [Table("trostrunde_pool")]
    public partial class TrostrundePool {
        [Column("id")]
        public long Id { get; set; }
        [Column("vernr")]
        public int Vernr { get; set; }
        [Column("knr")]
        public int Knr { get; set; }
        [Column("pool")]
        public int Pool { get; set; }
    }
}
