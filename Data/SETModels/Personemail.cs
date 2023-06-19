using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KSIMonitor.Data.SETModels {
    [Keyless]
    [Table("personemail")]
    public partial class Personemail {
        [Column("persontype")]
        public int Persontype { get; set; }
        [Column("id")]
        public int Id { get; set; }
        [Required]
        [Column("email")]
        [StringLength(255)]
        public string Email { get; set; }
        [Column("isaddress")]
        public int Isaddress { get; set; }
    }
}
