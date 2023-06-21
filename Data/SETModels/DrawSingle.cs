using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KSIMonitor.Data.SETModels {
    [Table("auslosungeinzel"), Keyless]
    public partial class DrawSingle {
        [Column("vernr")]
        public int EventID { get; set; }
        [Column("knr")]
        public int CategoryID { get; set; }
        [Column("nnr")]
        public int NameID { get; set; }
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
