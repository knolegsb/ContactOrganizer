namespace ContactOrganizer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Addresses",
                c => new
                    {
                        AddressId = c.Int(nullable: false, identity: true),
                        Line1 = c.String(),
                        Line2 = c.String(),
                        City = c.String(),
                        PostalCode = c.String(),
                        Country = c.String(),
                    })
                .PrimaryKey(t => t.AddressId);
            
            CreateTable(
                "dbo.Images",
                c => new
                    {
                        ImageID = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        FileName = c.String(),
                        Description = c.String(),
                        ImageType = c.String(),
                        ImageData = c.Binary(),
                        ImagePath = c.String(),
                    })
                .PrimaryKey(t => t.ImageID);
            
            CreateTable(
                "dbo.People",
                c => new
                    {
                        PersonID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        BirthDate = c.DateTime(nullable: false),
                        DateAdded = c.DateTime(nullable: false),
                        Interests = c.String(),
                        HomeAddress_AddressId = c.Int(),
                        ProfileImage_ImageID = c.Int(),
                    })
                .PrimaryKey(t => t.PersonID)
                .ForeignKey("dbo.Addresses", t => t.HomeAddress_AddressId)
                .ForeignKey("dbo.Images", t => t.ProfileImage_ImageID)
                .Index(t => t.HomeAddress_AddressId)
                .Index(t => t.ProfileImage_ImageID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.People", "ProfileImage_ImageID", "dbo.Images");
            DropForeignKey("dbo.People", "HomeAddress_AddressId", "dbo.Addresses");
            DropIndex("dbo.People", new[] { "ProfileImage_ImageID" });
            DropIndex("dbo.People", new[] { "HomeAddress_AddressId" });
            DropTable("dbo.People");
            DropTable("dbo.Images");
            DropTable("dbo.Addresses");
        }
    }
}
