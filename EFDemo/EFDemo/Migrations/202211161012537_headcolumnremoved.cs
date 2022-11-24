namespace EFDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class headcolumnremoved : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Departments", "DepartmentHead");
        }
        
        public override void Down()
        {
        }
    }
}
