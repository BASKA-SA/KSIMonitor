using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KSIMonitor.Data.SETModels {
    [Table("accessarea")]
    public partial class Accessarea {
        [Key, Column("accnr")]
        public int Accnr { get; set; }
        [Required, Column("bezeichnung"), StringLength(255)]
        public string Bezeichnung { get; set; }
    }
}
