using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KSIMonitor.Data.SETModels {
    [Table("accessarea")]
    public partial class AccessArea {
        [Key, Column("accnr")]
        public int AccessID { get; set; }
        [Required, Column("bezeichnung"), StringLength(255)]
        public string Name { get; set; }
    }
}
