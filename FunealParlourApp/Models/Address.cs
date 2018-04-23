namespace FunealParlourApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Address")]
    public partial class Address
    {
        public int AddressID { get; set; }

        public int? AddressType { get; set; }

        [Required]
        [StringLength(100)]
        public string AddressLine1 { get; set; }

        [StringLength(100)]
        public string AddressLine2 { get; set; }

        [StringLength(100)]
        public string AddressLine3 { get; set; }

        [Required]
        [StringLength(100)]
        public string Suburb { get; set; }

        [StringLength(1)]
        public string City { get; set; }

        [Required]
        [StringLength(50)]
        public string Province { get; set; }

        [Required]
        [StringLength(50)]
        public string Country { get; set; }

        public int? PostalCode { get; set; }

        public int MemberID { get; set; }

		public virtual Member Member { get; set; }
	}
}
