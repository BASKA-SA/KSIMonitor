using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KSIMonitor.Data.SETModels {
    [Table("veranstaltung_hotel"), Keyless]
    public partial class EventHotel {
        [Column("vernr")]
        public int EventID { get; set; }
        [Column("title"), Required, StringLength(255)]
        public string Title { get; set; }
        [Column("url"), Required, StringLength(255)]
        public string Url { get; set; }
        [Column("description", TypeName = "text")]
        public string Description { get; set; }
    }
}
