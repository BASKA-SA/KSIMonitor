using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KSIMonitor.Data.SETModels {
    [Keyless]
    [Table("veranstaltung_hotel")]
    public partial class VeranstaltungHotel {
        [Column("vernr")]
        public int Vernr { get; set; }
        [Required]
        [Column("title")]
        [StringLength(255)]
        public string Title { get; set; }
        [Required]
        [Column("url")]
        [StringLength(255)]
        public string Url { get; set; }
        [Column("description", TypeName = "text")]
        public string Description { get; set; }
    }
}
