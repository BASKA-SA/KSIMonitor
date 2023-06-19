using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KSIMonitor.Data.SETModels {
    [Keyless]
    [Table("veranstaltung_headofdelegation")]
    public partial class VeranstaltungHeadofdelegation {
        [Column("veranstaltung_id")]
        public uint VeranstaltungId { get; set; }
        [Column("club_id")]
        public uint ClubId { get; set; }
        [Column("person_id")]
        public uint PersonId { get; set; }
        [Column("person_type")]
        public int PersonType { get; set; }
    }
}
