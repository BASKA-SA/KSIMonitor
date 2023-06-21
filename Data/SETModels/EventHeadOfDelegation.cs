using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KSIMonitor.Data.SETModels {
    [Table("veranstaltung_headofdelegation"), Keyless]
    public partial class EventHeadOfDelegation {
        [Column("veranstaltung_id")]
        public uint VeranstaltungID { get; set; }
        [Column("club_id")]
        public uint ClubID { get; set; }
        [Column("person_id")]
        public uint PersonID { get; set; }
        [Column("person_type")]
        public int PersonType { get; set; }
    }
}
