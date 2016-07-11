namespace ContactOrganizer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Fixing : DbMigration
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
                        Person_PersonID = c.Int(),
                    })
                .PrimaryKey(t => t.AddressId)
                .ForeignKey("dbo.People", t => t.Person_PersonID)
                .Index(t => t.Person_PersonID);
            
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
                        FileType = c.Int(nullable: false),
                        Person_PersonID = c.Int(),
                    })
                .PrimaryKey(t => t.ImageID)
                .ForeignKey("dbo.People", t => t.Person_PersonID)
                .Index(t => t.Person_PersonID);
            
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
                    })
                .PrimaryKey(t => t.PersonID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Images", "Person_PersonID", "dbo.People");
            DropForeignKey("dbo.Addresses", "Person_PersonID", "dbo.People");
            DropIndex("dbo.Images", new[] { "Person_PersonID" });
            DropIndex("dbo.Addresses", new[] { "Person_PersonID" });
            DropTable("dbo.People");
            DropTable("dbo.Images");
            DropTable("dbo.Addresses");
        }
    }
}
