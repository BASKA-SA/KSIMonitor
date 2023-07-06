using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KSIMonitor.Data.SETModels {
    [Table("dtmdefaults")]
    public partial class DTMDefault {
        [Column("id"), Key]
        public int ID { get; set; }
        [Column("vernr")]
        public int EventID { get; set; }
        [Column("type"), StringLength(1)]
        public string Type { get; set; }
        [Column("sex"), StringLength(1)]
        public string Sex { get; set; }
        [Column("catname"), StringLength(255)]
        public string CategoryName { get; set; }
        [Column("fighttime")]
        public int FightTime { get; set; }
        [Column("color"), StringLength(7)]
        public string Color { get; set; }
    }
}
