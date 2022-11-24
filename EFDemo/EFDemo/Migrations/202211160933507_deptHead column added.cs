namespace EFDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class deptHeadcolumnadded : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Departments", "DepartmentHead", c => c.String());
        }
        
        public override void Down()
        {
        }
    }
}
