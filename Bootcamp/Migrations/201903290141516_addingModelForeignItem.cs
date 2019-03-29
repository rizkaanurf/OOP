namespace Bootcamp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addingModelForeignItem : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Items", "IsDelete", c => c.Boolean(nullable: false));
            AddColumn("dbo.Items", "Supplier_Id", c => c.Int());
            CreateIndex("dbo.Items", "Supplier_Id");
            AddForeignKey("dbo.Items", "Supplier_Id", "dbo.Suppliers", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Items", "Supplier_Id", "dbo.Suppliers");
            DropIndex("dbo.Items", new[] { "Supplier_Id" });
            DropColumn("dbo.Items", "Supplier_Id");
            DropColumn("dbo.Items", "IsDelete");
        }
    }
}
