namespace FunealParlourApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class IntiailMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Address",
                c => new
                    {
                        AddressID = c.Int(nullable: false, identity: true),
                        AddressType = c.Int(),
                        AddressLine1 = c.String(nullable: false, maxLength: 100),
                        AddressLine2 = c.String(maxLength: 100),
                        AddressLine3 = c.String(maxLength: 100),
                        Suburb = c.String(nullable: false, maxLength: 100),
                        City = c.String(maxLength: 1),
                        Province = c.String(nullable: false, maxLength: 50),
                        Country = c.String(nullable: false, maxLength: 50),
                        PostalCode = c.Int(),
                        MemberID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.AddressID)
                .ForeignKey("dbo.Member", t => t.MemberID, cascadeDelete: true)
                .Index(t => t.MemberID);
            
            CreateTable(
                "dbo.Member",
                c => new
                    {
                        MemberID = c.Int(nullable: false, identity: true),
                        ParentMemberID = c.Int(),
                        SocietyGroupID = c.Int(),
                        PolicyNumber = c.String(maxLength: 50),
                        Initials = c.String(maxLength: 50),
                        Title = c.Int(nullable: false),
                        FullName = c.String(maxLength: 250),
                        Surname = c.String(maxLength: 250),
                        Age = c.Int(),
                        DateOfBirth = c.DateTime(),
                        IDNumber = c.String(maxLength: 13),
                        PassportNumber = c.String(maxLength: 20),
                        Gender = c.Int(),
                        IsSACitizen = c.Boolean(nullable: false),
                        Country = c.String(maxLength: 100),
                        IsEmployed = c.Boolean(nullable: false),
                        Employer = c.String(maxLength: 50),
                        EmployerContactNumber = c.String(maxLength: 50),
                        ContactNumber = c.String(maxLength: 50),
                        TelephoneHome = c.String(maxLength: 50),
                        OtherContactNumber = c.String(maxLength: 50),
                        EmailAddress = c.String(maxLength: 50),
                        IsChroniclLLness = c.Boolean(),
                        ChronicILLnessDetails = c.String(),
                        HasDebts = c.Boolean(),
                        DebtsDetails = c.String(),
                        Active = c.Boolean(),
                        DateCreated = c.DateTime(),
                        DateModified = c.DateTime(),
                        UserCreated = c.Int(),
                        UserModified = c.Int(),
                        UserID = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.MemberID);
            
            CreateTable(
                "dbo.BankAccount",
                c => new
                    {
                        BankAccountID = c.Int(nullable: false, identity: true),
                        Bank = c.Int(),
                        MemberID = c.Int(nullable: false),
                        AccountType = c.Int(),
                        BankAccoutNumber = c.String(maxLength: 50),
                        BranchCode = c.String(maxLength: 50),
                        DateCreated = c.DateTime(),
                        DateModified = c.DateTime(),
                        UserID = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.BankAccountID)
                .ForeignKey("dbo.Member", t => t.MemberID, cascadeDelete: true)
                .Index(t => t.MemberID);
            
            CreateTable(
                "dbo.Beneficiary",
                c => new
                    {
                        BenficiaryID = c.Int(nullable: false),
                        MemberID = c.Int(nullable: false),
                        Title = c.Int(),
                        Initials = c.String(maxLength: 50),
                        Gender = c.Int(),
                        IDNumber = c.String(maxLength: 50),
                        Surname = c.String(maxLength: 50),
                        FirstNames = c.String(maxLength: 50),
                        ContactNumber = c.String(maxLength: 50),
                        TelephoneHome = c.String(maxLength: 50),
                        OtherContactNumber = c.String(maxLength: 50),
                        Relationship = c.Int(),
                        DateCreated = c.DateTime(),
                        DateModified = c.DateTime(),
                        UserID = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.BenficiaryID)
                .ForeignKey("dbo.Member", t => t.MemberID, cascadeDelete: true)
                .Index(t => t.MemberID);
            
            CreateTable(
                "dbo.AspNetRoles",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name, unique: true, name: "RoleNameIndex");
            
            CreateTable(
                "dbo.AspNetUserRoles",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        RoleId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.UserId, t.RoleId })
                .ForeignKey("dbo.AspNetRoles", t => t.RoleId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.RoleId);
            
            CreateTable(
                "dbo.AspNetUsers",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Email = c.String(maxLength: 256),
                        EmailConfirmed = c.Boolean(nullable: false),
                        PasswordHash = c.String(),
                        SecurityStamp = c.String(),
                        PhoneNumber = c.String(),
                        PhoneNumberConfirmed = c.Boolean(nullable: false),
                        TwoFactorEnabled = c.Boolean(nullable: false),
                        LockoutEndDateUtc = c.DateTime(),
                        LockoutEnabled = c.Boolean(nullable: false),
                        AccessFailedCount = c.Int(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.UserName, unique: true, name: "UserNameIndex");
            
            CreateTable(
                "dbo.AspNetUserClaims",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(nullable: false, maxLength: 128),
                        ClaimType = c.String(),
                        ClaimValue = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.AspNetUserLogins",
                c => new
                    {
                        LoginProvider = c.String(nullable: false, maxLength: 128),
                        ProviderKey = c.String(nullable: false, maxLength: 128),
                        UserId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.LoginProvider, t.ProviderKey, t.UserId })
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AspNetUserRoles", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserLogins", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserClaims", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserRoles", "RoleId", "dbo.AspNetRoles");
            DropForeignKey("dbo.Beneficiary", "MemberID", "dbo.Member");
            DropForeignKey("dbo.BankAccount", "MemberID", "dbo.Member");
            DropForeignKey("dbo.Address", "MemberID", "dbo.Member");
            DropIndex("dbo.AspNetUserLogins", new[] { "UserId" });
            DropIndex("dbo.AspNetUserClaims", new[] { "UserId" });
            DropIndex("dbo.AspNetUsers", "UserNameIndex");
            DropIndex("dbo.AspNetUserRoles", new[] { "RoleId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "UserId" });
            DropIndex("dbo.AspNetRoles", "RoleNameIndex");
            DropIndex("dbo.Beneficiary", new[] { "MemberID" });
            DropIndex("dbo.BankAccount", new[] { "MemberID" });
            DropIndex("dbo.Address", new[] { "MemberID" });
            DropTable("dbo.AspNetUserLogins");
            DropTable("dbo.AspNetUserClaims");
            DropTable("dbo.AspNetUsers");
            DropTable("dbo.AspNetUserRoles");
            DropTable("dbo.AspNetRoles");
            DropTable("dbo.Beneficiary");
            DropTable("dbo.BankAccount");
            DropTable("dbo.Member");
            DropTable("dbo.Address");
        }
    }
}
