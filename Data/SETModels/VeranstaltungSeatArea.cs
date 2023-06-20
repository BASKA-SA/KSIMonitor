using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KSIMonitor.Data.SETModels {
    [Table("veranstaltung_seat_area")]
    public partial class VeranstaltungSeatArea {
        [Column("verid")]
        public int VerID { get; set; }
        [Column("id"), Key]
        public int ID { get; set; }
        [Column("title"), Required, StringLength(255)]
        public string Title { get; set; }
    }
}
