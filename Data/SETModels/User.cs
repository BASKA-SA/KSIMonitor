using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KSIMonitor.Data.SETModels {
    [Table("user")]
    public partial class User {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("user")]
        [StringLength(50)]
        public string User1 { get; set; }
        [Required]
        [Column("passwort")]
        [StringLength(50)]
        public string Passwort { get; set; }
        [Column("email")]
        [StringLength(255)]
        public string Email { get; set; }
        [Column("gesperrt")]
        public int Gesperrt { get; set; }
        [Column("titel")]
        [StringLength(50)]
        public string Titel { get; set; }
        [Column("vorname")]
        [StringLength(100)]
        public string Vorname { get; set; }
        [Column("nachname")]
        [StringLength(100)]
        public string Nachname { get; set; }
        [Column("geburtstag", TypeName = "date")]
        public DateTime? Geburtstag { get; set; }
        [Column("adresse")]
        [StringLength(255)]
        public string Adresse { get; set; }
        [Column("plz")]
        [StringLength(50)]
        public string Plz { get; set; }
        [Column("ort")]
        [StringLength(50)]
        public string Ort { get; set; }
        [Column("nation")]
        public int? Nation { get; set; }
        [Column("telefon")]
        [StringLength(50)]
        public string Telefon { get; set; }
        [Column("fax")]
        [StringLength(50)]
        public string Fax { get; set; }
        [Column("mobiltelefon")]
        [StringLength(50)]
        public string Mobiltelefon { get; set; }
        [Column("create", TypeName = "timestamp")]
        public DateTime Create { get; set; }
        [Column("aktiv")]
        public int Aktiv { get; set; }
        [Column("billingaddress", TypeName = "text")]
        public string Billingaddress { get; set; }
        [Column("mandant")]
        public int Mandant { get; set; }
        [Column("autopayment")]
        public int Autopayment { get; set; }
        [Column("paypalaccount")]
        [StringLength(255)]
        public string Paypalaccount { get; set; }
        [Column("bankaccount", TypeName = "text")]
        public string Bankaccount { get; set; }
        [Column("extregoption")]
        public int? Extregoption { get; set; }
        [Column("gestpayshoplogin")]
        [StringLength(30)]
        public string Gestpayshoplogin { get; set; }
        [Column("privacypolicyagree")]
        public int Privacypolicyagree { get; set; }
        [Column("privacypolicyagreedate", TypeName = "timestamp")]
        public DateTime Privacypolicyagreedate { get; set; }
        [Column("stripepk")]
        [StringLength(255)]
        public string Stripepk { get; set; }
        [Column("stripesk")]
        [StringLength(255)]
        public string Stripesk { get; set; }
    }
}
