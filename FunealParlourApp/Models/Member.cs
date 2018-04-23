namespace FunealParlourApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Member")]
    public partial class Member
    {
        public int MemberID { get; set; }

        public int? ParentMemberID { get; set; }

        public int? SocietyGroupID { get; set; }

        [StringLength(50)]
        public string PolicyNumber { get; set; }

        [StringLength(50)]
        public string Initials { get; set; }

        public int Title { get; set; }

        [StringLength(250)]
        public string FullName { get; set; }

        [StringLength(250)]
        public string Surname { get; set; }

        public int? Age { get; set; }

        public DateTime? DateOfBirth { get; set; }

        [StringLength(13)]
        public string IDNumber { get; set; }

        [StringLength(20)]
        public string PassportNumber { get; set; }

        public int? Gender { get; set; }

        public bool IsSACitizen { get; set; }

        [StringLength(100)]
        public string Country { get; set; }

        public bool IsEmployed { get; set; }

        [StringLength(50)]
        public string Employer { get; set; }

        [StringLength(50)]
        public string EmployerContactNumber { get; set; }

        [StringLength(50)]
        public string ContactNumber { get; set; }

        [StringLength(50)]
        public string TelephoneHome { get; set; }

        [StringLength(50)]
        public string OtherContactNumber { get; set; }

        [StringLength(50)]
        public string EmailAddress { get; set; }

        public bool? IsChroniclLLness { get; set; }

        public string ChronicILLnessDetails { get; set; }

        public bool? HasDebts { get; set; }

        public string DebtsDetails { get; set; }

        public bool? Active { get; set; }

        public DateTime? DateCreated { get; set; }

        public DateTime? DateModified { get; set; }

        public int? UserCreated { get; set; }

        public int? UserModified { get; set; }

        [StringLength(128)]
        public string UserID { get; set; }

		public virtual ICollection<Address> Addresses { get; set; }
	}
}
