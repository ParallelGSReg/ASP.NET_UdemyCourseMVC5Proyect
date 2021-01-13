namespace MoviesRental.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateCostumers : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Customers (Name, Birthdate, IsSubscribedToNewsletter, MembershipTypeId) VALUES ('Jose San Martin', 01/05/1980, 'False', 1)");
            Sql("INSERT INTO Customers (Name, Birthdate, IsSubscribedToNewsletter, MembershipTypeId) VALUES ('Ricardo Lopez', 07/09/1960, 'True', 2)");
            //Sql("INSERT INTO Customers (Name, Birthdate, IsSubscribedToNewsletter, MembershipTypeId) VALUES ('Jose San Mart{in', 01/05/1980, 'False', 1)");            
            //Sql("DELETE FROM Customers WHERE Name = 'John Smith'");
            //Sql("UPDATE Customers SET Birthdate = CAST('1981-06-01' AS DATETIME) WHERE Id = 2");

        }


        public override void Down()
        {
        }
    }
}
