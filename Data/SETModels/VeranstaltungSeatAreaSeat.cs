using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KSIMonitor.Data.SETModels {
    [Table("veranstaltung_seat_area_seats")]
    public partial class VeranstaltungSeatAreaSeat {
        [Column("id"), Key]
        public int ID { get; set; }
        [Column("areaid")]
        public int Areaid { get; set; }
        [Column("row")]
        public int Row { get; set; }
        [Column("seat")]
        public int Seat { get; set; }
        [Column("reserved")]
        public int? Reserved { get; set; }
        [Column("isavailable")]
        public int Isavailable { get; set; }
        [Column("customname"), StringLength(100)]
        public string Customname { get; set; }
    }
}
