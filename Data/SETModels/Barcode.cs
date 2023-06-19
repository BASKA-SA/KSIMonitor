using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KSIMonitor.Data.SETModels {
    [Keyless]
    [Table("barcode")]
    public partial class Barcode {
        [Column("verid")]
        public int Verid { get; set; }
        [Required]
        [Column("barcode")]
        [StringLength(50)]
        public string Barcode1 { get; set; }
        [Column("id")]
        public int Id { get; set; }
        [Column("persontype")]
        public int Persontype { get; set; }
        [Column("personid")]
        public int Personid { get; set; }
    }
}
