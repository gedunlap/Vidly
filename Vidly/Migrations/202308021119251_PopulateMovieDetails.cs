namespace Vidly.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class PopulateMovieDetails : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Movies (Title, Genre, ReleaseDate, DateAdded, NumerInStock) VALUES ('Vanilla Sky', 'Thriller', 'December 10, 2001', 'August 2, 2023', '12')");
            Sql("INSERT INTO Movies (Title, Genre, ReleaseDate, DateAdded, NumerInStock) VALUES ('Fight Club', 'Thriller','October 15, 1999', 'August 2, 2023', '7')");
            Sql("INSERT INTO Movies (Title, Genre, ReleaseDate, DateAdded, NumerInStock) VALUES ('How To Train Your Dragon', 'Family','March 21, 2010', 'August 2, 2023', '4')");

        }

        public override void Down()
        {
        }
    }
}
