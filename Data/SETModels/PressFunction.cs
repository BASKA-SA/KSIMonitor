using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KSIMonitor.Data.SETModels {
    [Table("press_function")]
    public partial class PressFunction {
        [Column("id"), Key]
        public int ID { get; set; }
        [Column("name"), Required, StringLength(150)]
        public string Name { get; set; }
    }
}
