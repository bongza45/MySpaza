namespace MySpaza.DataAccess.SQL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateOrderTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Orders", "ZipCode", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Orders", "ZipCode");
        }
    }
}
