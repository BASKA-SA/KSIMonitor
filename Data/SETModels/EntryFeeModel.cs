using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KSIMonitor.Data.SETModels {
    [Table("entryfeemodel")]
    public partial class EntryFeeModel {
        [Column("id"), Key]
        public int ID { get; set; }
        [Column("model")]
        public int Model { get; set; }
        [Column("verid")]
        public int VerID { get; set; }
        [Column("discountentry")]
        public int Discountentry { get; set; }
        [Column("discount")]
        public float Discount { get; set; }
        [Column("maxclub")]
        public float Maxclub { get; set; }
        [Column("enablediscount")]
        public int Enablediscount { get; set; }
        [Column("enablemaxclub")]
        public int Enablemaxclub { get; set; }
        [Column("indentrydiscounttype")]
        public int Indentrydiscounttype { get; set; }
        [Column("discountflat")]
        public float Discountflat { get; set; }
        [Column("discountcatflat", TypeName = "text")]
        public string Discountcatflat { get; set; }
        [Column("coachfee")]
        public float Coachfee { get; set; }
        [Column("dateentryfee")]
        public int Dateentryfee { get; set; }
        [Column("datecatentryfeecoach", TypeName = "text")]
        public string Datecatentryfeecoach { get; set; }
        [Column("datecatentryfeeind", TypeName = "text")]
        public string Datecatentryfeeind { get; set; }
        [Column("datecatentryfeeteam", TypeName = "text")]
        public string Datecatentryfeeteam { get; set; }
        [Column("feeigonrediscount", TypeName = "text")]
        public string Feeigonrediscount { get; set; }
        [Column("refereefee")]
        public float Refereefee { get; set; }
        [Column("officialfee")]
        public float Officialfee { get; set; }
        [Column("datecatentryfeereferee", TypeName = "text")]
        public string Datecatentryfeereferee { get; set; }
        [Column("datecatentryfeeofficial", TypeName = "text")]
        public string Datecatentryfeeofficial { get; set; }
        [Column("nosportsidextrafee")]
        public float Nosportsidextrafee { get; set; }
        [Column("enablediscountteam")]
        public int Enablediscountteam { get; set; }
        [Column("discountentryteam")]
        public int Discountentryteam { get; set; }
        [Column("indentrydiscounttypeteam")]
        public int Indentrydiscounttypeteam { get; set; }
        [Column("discountteam")]
        public float Discountteam { get; set; }
        [Column("discountflatteam")]
        public float Discountflatteam { get; set; }
        [Column("discountcatflatteam", TypeName = "text")]
        public string Discountcatflatteam { get; set; }
        [Column("clubfee")]
        public float Clubfee { get; set; }
        [Column("teamentryfeepercompetitor")]
        public int Teamentryfeepercompetitor { get; set; }
        [Column("includealldiscount")]
        public int? Includealldiscount { get; set; }
        [Column("includealldiscountteam")]
        public int? Includealldiscountteam { get; set; }
        [Column("dateentryfeewl")]
        public int? Dateentryfeewl { get; set; }
        [Column("binomiosamecode")]
        public int? Binomiosamecode { get; set; }
        [Column("binomioageflatfeeenable")]
        public int? Binomioageflatfeeenable { get; set; }
        [Column("binomioageflatfee")]
        public float? Binomioageflatfee { get; set; }
        [Column("binomioageflatfeeage")]
        public int? Binomioageflatfeeage { get; set; }
        [Column("customdescription", TypeName = "text")]
        public string Customdescription { get; set; }
    }
}
