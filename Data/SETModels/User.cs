using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KSIMonitor.Data.SETModels {
    [Table("user")]
    public partial class User {
        [Column("id"), Key]
        public int ID { get; set; }
        [Column("user"), StringLength(50)]
        public string Username { get; set; }
        [Column("passwort"), Required, StringLength(50)]
        public string Password { get; set; }
        [Column("email"), StringLength(255)]
        public string Email { get; set; }
        [Column("gesperrt")]
        public int Blocked { get; set; }
        [Column("titel"), StringLength(50)]
        public string Title { get; set; }
        [Column("vorname"), StringLength(100)]
        public string FirstName { get; set; }
        [Column("nachname"), StringLength(100)]
        public string LastName { get; set; }
        [Column("geburtstag", TypeName = "date")]
        public DateTime? BirthDate { get; set; }
        [Column("adresse"), StringLength(255)]
        public string Address { get; set; }
        [Column("plz"), StringLength(50)]
        public string PostCode { get; set; }
        [Column("ort"), StringLength(50)]
        public string City { get; set; }
        [Column("nation")]
        public int? NationID { get; set; }
        [Column("telefon"), StringLength(50)]
        public string PhoneNumber { get; set; }
        [Column("fax"), StringLength(50)]
        public string Fax { get; set; }
        [Column("mobiltelefon"), StringLength(50)]
        public string CellNumber { get; set; }
        [Column("create", TypeName = "timestamp")]
        public DateTime Created { get; set; }
        [Column("aktiv")]
        public int Active { get; set; }
        [Column("billingaddress", TypeName = "text")]
        public string BillingAddress { get; set; }
        [Column("mandant")]
        public int Client { get; set; }
        [Column("autopayment")]
        public int AutoPayment { get; set; }
        [Column("paypalaccount"), StringLength(255)]
        public string PayPalAccount { get; set; }
        [Column("bankaccount", TypeName = "text")]
        public string BankAccount { get; set; }
        [Column("extregoption")]
        public int? ExtRegOption { get; set; }
        [Column("gestpayshoplogin"), StringLength(30)]
        public string GestPayShopLogin { get; set; }
        [Column("privacypolicyagree")]
        public int PrivacyPolicyAgree { get; set; }
        [Column("privacypolicyagreedate", TypeName = "timestamp")]
        public DateTime PrivacyPolicyAgreeDate { get; set; }
        [Column("stripepk"), StringLength(255)]
        public string StripePK { get; set; }
        [Column("stripesk"), StringLength(255)]
        public string StripeSK { get; set; }
    }
}
