using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KSIMonitor.Data.SETModels {
    [Table("barcode"), Keyless]
    public partial class Barcode {
        [Column("verid")]
        public int EventID { get; set; }
        [Column("barcode"), Required, StringLength(50)]
        public string Barcode1 { get; set; }
        [Column("id")]
        public int ID { get; set; }
        [Column("persontype")]
        public int PersonType { get; set; }
        [Column("personid")]
        public int PersonID { get; set; }
    }
}
