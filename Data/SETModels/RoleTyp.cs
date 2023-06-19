using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KSIMonitor.Data.SETModels {
    [Table("role_typ")]
    public partial class RoleTyp {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Required]
        [Column("bezeichnung")]
        [StringLength(255)]
        public string Bezeichnung { get; set; }
    }
}
