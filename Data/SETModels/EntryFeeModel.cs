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
        public int EventID { get; set; }
        [Column("discountentry")]
        public int DiscountEntry { get; set; }
        [Column("discount")]
        public float Discount { get; set; }
        [Column("maxclub")]
        public float MaxClub { get; set; }
        [Column("enablediscount")]
        public int EnableDiscount { get; set; }
        [Column("enablemaxclub")]
        public int EnableMaxClub { get; set; }
        [Column("indentrydiscounttype")]
        public int IndividualEntryDiscountType { get; set; }
        [Column("discountflat")]
        public float DiscountFlat { get; set; }
        [Column("discountcatflat", TypeName = "text")]
        public string DiscountCategoryFlat { get; set; }
        [Column("coachfee")]
        public float CoachFee { get; set; }
        [Column("dateentryfee")]
        public int DateEntryFee { get; set; }
        [Column("datecatentryfeecoach", TypeName = "text")]
        public string DateCatEntryFeeCoach { get; set; }
        [Column("datecatentryfeeind", TypeName = "text")]
        public string DateCatEntryFeeIndividual { get; set; }
        [Column("datecatentryfeeteam", TypeName = "text")]
        public string DateCatEntryFeeTeam { get; set; }
        [Column("feeigonrediscount", TypeName = "text")]
        public string FeeIgnoreDiscount { get; set; }
        [Column("refereefee")]
        public float RefereeFee { get; set; }
        [Column("officialfee")]
        public float OfficialFee { get; set; }
        [Column("datecatentryfeereferee", TypeName = "text")]
        public string DateCatEntryFeeReferee { get; set; }
        [Column("datecatentryfeeofficial", TypeName = "text")]
        public string DateCatEntryFeeOfficial { get; set; }
        [Column("nosportsidextrafee")]
        public float NoSportsIDExtraFee { get; set; }
        [Column("enablediscountteam")]
        public int EnableDiscountTeam { get; set; }
        [Column("discountentryteam")]
        public int DiscountEntryTeam { get; set; }
        [Column("indentrydiscounttypeteam")]
        public int IndividualEntryDiscountTypeTeam { get; set; }
        [Column("discountteam")]
        public float DiscountTeam { get; set; }
        [Column("discountflatteam")]
        public float DiscountFlatTeam { get; set; }
        [Column("discountcatflatteam", TypeName = "text")]
        public string DiscountCatFlatTeam { get; set; }
        [Column("clubfee")]
        public float ClubFee { get; set; }
        [Column("teamentryfeepercompetitor")]
        public int TeamEntryFeePerCompetitor { get; set; }
        [Column("includealldiscount")]
        public int? IncludeAllDiscount { get; set; }
        [Column("includealldiscountteam")]
        public int? IncludeAllDiscountTeam { get; set; }
        [Column("dateentryfeewl")]
        public int? DateEntryFeeWL { get; set; }
        [Column("binomiosamecode")]
        public int? BinomioSameCode { get; set; }
        [Column("binomioageflatfeeenable")]
        public int? BinomioAgeFlatFeeEnable { get; set; }
        [Column("binomioageflatfee")]
        public float? BinomioAgeFlatFee { get; set; }
        [Column("binomioageflatfeeage")]
        public int? BinomioAgeFlatFeeAge { get; set; }
        [Column("customdescription", TypeName = "text")]
        public string CustomDescription { get; set; }
    }
}
