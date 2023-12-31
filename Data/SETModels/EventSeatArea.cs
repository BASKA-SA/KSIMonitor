using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KSIMonitor.Data.SETModels {
    [Table("veranstaltung_seat_area")]
    public partial class EventSeatArea {
        [Column("verid")]
        public int EventID { get; set; }
        [Column("id"), Key]
        public int ID { get; set; }
        [Column("title"), Required, StringLength(255)]
        public string Title { get; set; }
    }
}
