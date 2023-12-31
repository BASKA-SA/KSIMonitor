using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KSIMonitor.Data.SETModels {
    [Table("timetable")]
    public partial class Timetable {
        [Column("id"), Key]
        public int ID { get; set; }
        [Column("vernr")]
        public int EventID { get; set; }
        [Column("date", TypeName = "date")]
        public DateTime Date { get; set; }
        [Column("tatamis")]
        public int Tatamis { get; set; }
        [Column("knr")]
        public int CategoryID { get; set; }
        [Column("catname", TypeName = "text")]
        public string CategoryName { get; set; }
        [Column("sex"), Required, StringLength(1)]
        public string Sex { get; set; }
        [Column("type")]
        public int Type { get; set; }
        [Column("tatami")]
        public int Tatami { get; set; }
        [Column("pool")]
        public int Pool { get; set; }
        [Column("pools")]
        public int Pools { get; set; }
        [Column("entries")]
        public int Entries { get; set; }
        [Column("fighttime")]
        public int FightTime { get; set; }
        [Column("edited")]
        public int Edited { get; set; }
        [Column("color"), Required, StringLength(7)]
        public string Color { get; set; }
        [Column("starttime", TypeName = "timestamp")]
        public DateTime StartTime { get; set; }
        [Column("endtime", TypeName = "timestamp")]
        public DateTime EndTime { get; set; }
        [Column("comment"), StringLength(255)]
        public string Comment { get; set; }
        [Column("matchnumber")]
        public int MatchNumber { get; set; }
    }
}
