namespace ContactOrganizer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddForeignKeyInImageAndAddressTable : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Addresses", "Person_PersonID", "dbo.People");
            DropForeignKey("dbo.Images", "Person_PersonID", "dbo.People");
            DropIndex("dbo.Addresses", new[] { "Person_PersonID" });
            DropIndex("dbo.Images", new[] { "Person_PersonID" });
            RenameColumn(table: "dbo.Addresses", name: "Person_PersonID", newName: "PersonID");
            RenameColumn(table: "dbo.Images", name: "Person_PersonID", newName: "PersonID");
            AlterColumn("dbo.Addresses", "PersonID", c => c.Int(nullable: false));
            AlterColumn("dbo.Images", "PersonID", c => c.Int(nullable: false));
            CreateIndex("dbo.Addresses", "PersonID");
            CreateIndex("dbo.Images", "PersonID");
            AddForeignKey("dbo.Addresses", "PersonID", "dbo.People", "PersonID", cascadeDelete: true);
            AddForeignKey("dbo.Images", "PersonID", "dbo.People", "PersonID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Images", "PersonID", "dbo.People");
            DropForeignKey("dbo.Addresses", "PersonID", "dbo.People");
            DropIndex("dbo.Images", new[] { "PersonID" });
            DropIndex("dbo.Addresses", new[] { "PersonID" });
            AlterColumn("dbo.Images", "PersonID", c => c.Int());
            AlterColumn("dbo.Addresses", "PersonID", c => c.Int());
            RenameColumn(table: "dbo.Images", name: "PersonID", newName: "Person_PersonID");
            RenameColumn(table: "dbo.Addresses", name: "PersonID", newName: "Person_PersonID");
            CreateIndex("dbo.Images", "Person_PersonID");
            CreateIndex("dbo.Addresses", "Person_PersonID");
            AddForeignKey("dbo.Images", "Person_PersonID", "dbo.People", "PersonID");
            AddForeignKey("dbo.Addresses", "Person_PersonID", "dbo.People", "PersonID");
        }
    }
}
