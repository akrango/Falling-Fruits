namespace FallingFruits.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Users (Name,Score) VALUES ('Krango',20)");
            Sql("INSERT INTO Users (Name,Score) VALUES ('Stejs',50)");
            Sql("INSERT INTO Users (Name,Score) VALUES ('Elena',10)");
        }
        
        public override void Down()
        {
        }
    }
}
