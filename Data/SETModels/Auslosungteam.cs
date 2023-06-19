using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KSIMonitor.Data.SETModels {
    [Keyless]
    [Table("auslosungteam")]
    public partial class Auslosungteam {
        [Column("vernr")]
        public int Vernr { get; set; }
        [Column("knr")]
        public int Knr { get; set; }
        [Column("vereinnr")]
        public int Vereinnr { get; set; }
        [Required]
        [Column("mannschaft", TypeName = "text")]
        public string Mannschaft { get; set; }
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
