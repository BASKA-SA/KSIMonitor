using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KSIMonitor.Data.SETModels {
    [Keyless]
    [Table("auslosungeinzel")]
    public partial class Auslosungeinzel {
        [Column("vernr")]
        public int Vernr { get; set; }
        [Column("knr")]
        public int Knr { get; set; }
        [Column("nnr")]
        public int Nnr { get; set; }
        [Column("pos")]
        public int Pos { get; set; }
        [Column("pool")]
        public int Pool { get; set; }
        [Column("del")]
        public int? Del { get; set; }
        [Column("fieldpos")]
        public int Fieldpos { get; set; }
    }
}
