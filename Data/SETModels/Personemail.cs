using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KSIMonitor.Data.SETModels {
    [Table("personemail"), Keyless]
    public partial class Personemail {
        [Column("persontype")]
        public int Persontype { get; set; }
        [Column("id")]
        public int ID { get; set; }
        [Column("email"), Required]
        [StringLength(255)]
        public string Email { get; set; }
        [Column("isaddress")]
        public int Isaddress { get; set; }
    }
}
