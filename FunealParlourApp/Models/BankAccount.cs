namespace FunealParlourApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BankAccount")]
    public partial class BankAccount
    {
        public int BankAccountID { get; set; }

        public int? Bank { get; set; }

        public int MemberID { get; set; }

        public int? AccountType { get; set; }

        [StringLength(50)]
        public string BankAccoutNumber { get; set; }

        [StringLength(50)]
        public string BranchCode { get; set; }

        public DateTime? DateCreated { get; set; }

        public DateTime? DateModified { get; set; }

        [StringLength(128)]
        public string UserID { get; set; }

		public virtual Member Member { get; set; }
	}
}
