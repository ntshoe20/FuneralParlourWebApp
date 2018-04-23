namespace FunealParlourApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Beneficiary")]
    public partial class Beneficiary
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BenficiaryID { get; set; }

        public int MemberID { get; set; }

        public int? Title { get; set; }

        [StringLength(50)]
        public string Initials { get; set; }

        public int? Gender { get; set; }

        [StringLength(50)]
        public string IDNumber { get; set; }

        [StringLength(50)]
        public string Surname { get; set; }

        [StringLength(50)]
        public string FirstNames { get; set; }

        [StringLength(50)]
        public string ContactNumber { get; set; }

        [StringLength(50)]
        public string TelephoneHome { get; set; }

        [StringLength(50)]
        public string OtherContactNumber { get; set; }

        public int? Relationship { get; set; }

        public DateTime? DateCreated { get; set; }

        public DateTime? DateModified { get; set; }

        [StringLength(50)]
        public string UserID { get; set; }

		public virtual Member Member { get; set; }
	}
}
