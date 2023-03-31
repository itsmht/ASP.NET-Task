namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMembershipTypes : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO MembershipTypes (Id,Name, SignUpFee, DurationInMonths, DiscountRate) VALUES (1, 'Free', 0, 0, 0)");
            Sql("INSERT INTO MembershipTypes (Id, Name, SignUpFee, DurationInMonths, DiscountRate) VALUES (2, 'Basic', 30, 1, 10)");
            Sql("INSERT INTO MembershipTypes (Id, Name, SignUpFee, DurationInMonths, DiscountRate) VALUES (3, 'Premium', 90, 3, 15)");
            Sql("INSERT INTO MembershipTypes (Id, Name, SignUpFee, DurationInMonths, DiscountRate) VALUES (4,'Ultimate', 300, 12, 20)");
        }
        
        public override void Down()
        {
        }
    }
}
