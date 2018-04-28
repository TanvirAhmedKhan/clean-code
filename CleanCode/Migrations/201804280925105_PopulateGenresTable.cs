namespace CleanCode.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class PopulateGenresTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres (Id, Name) VALUES (1, 'Tanvir')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (2, 'Ahmed')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (3, 'Khan')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (4, 'Country')");
        }
        
        public override void Down()
        {
            Sql("DELETE FROM Genres WHERE Id IN (1,2,3,4)");
        }
    }
}
