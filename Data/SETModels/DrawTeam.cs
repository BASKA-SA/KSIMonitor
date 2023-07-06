using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KSIMonitor.Data.SETModels {
    [Table("auslosungteam"), Keyless]
    public partial class DrawTeam {
        [Column("vernr")]
        public int EventID { get; set; }
        [Column("knr")]
        public int CategoryID { get; set; }
        [Column("vereinnr")]
        public int AssociationID { get; set; }
        [Column("mannschaft", TypeName = "text"), Required]
        public string Team { get; set; }
        [Column("pos")]
        public int Pos { get; set; }
        [Column("pool")]
        public int Pool { get; set; }
        [Column("del")]
        public int? Del { get; set; }
        [Column("fieldpos")]
        public int FieldPos { get; set; }
    }
}
