namespace FunealParlourApp.Context
{
	using System;
	using System.Data.Entity;
	using System.ComponentModel.DataAnnotations.Schema;
	using System.Linq;
	using System.Data.Entity.ModelConfiguration.Conventions;
	using FunealParlourApp.Models;
	using Microsoft.AspNet.Identity.EntityFramework;

	public partial class FuneralParlourDbContext : IdentityDbContext<ApplicationUser> //Override IdentityDbContext in order to use Migrations of Identity tables 
	{
		public FuneralParlourDbContext()
			: base("FuneralParlourDbContext")
		{
		}

		public virtual DbSet<Address> Addresses { get; set; }
		public virtual DbSet<BankAccount> BankAccounts { get; set; }
		public virtual DbSet<Member> Members { get; set; }
		public virtual DbSet<Beneficiary> Beneficiaries { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			//Maps pluralised tables to their singular counterpart in the database
			modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

			//Must be called when using IdentityDbContext or else migrations won't work
			base.OnModelCreating(modelBuilder);
		}
	}
}
