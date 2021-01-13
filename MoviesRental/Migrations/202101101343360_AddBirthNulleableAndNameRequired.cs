namespace MoviesRental.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddBirthNulleableAndNameRequired : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "Birthdate", c => c.DateTime());
            AlterColumn("dbo.MembershipTypes", "Name", c => c.String(nullable: false, maxLength: 50));
            DropColumn("dbo.Customers", "Birthday");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Customers", "Birthday", c => c.DateTime(nullable: false));
            AlterColumn("dbo.MembershipTypes", "Name", c => c.String(maxLength: 50));
            DropColumn("dbo.Customers", "Birthdate");
        }
    }
}
