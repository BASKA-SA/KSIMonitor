using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KSIMonitor.Data.SETModels {
    [Table("press_type")]
    public partial class PressType {
        [Column("id"), Key]
        public int Id { get; set; }
        [Column("name"), Required, StringLength(150)]
        public string Name { get; set; }
    }
}
