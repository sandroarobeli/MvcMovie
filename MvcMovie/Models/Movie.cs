using System.ComponentModel.DataAnnotations;

namespace MvcMovie.Models
{
    public class Movie
    {
        private DateTime _releaseDate;
        public int Id { get; set; }
        public string? Title { get; set; }
        // Postgres newer version has problem with compatibility of DateTime types with
        // .NET, so in Postgres server DB, I changed timestamp type into date type. 
        // For the purposes of entering DATES ONLY, it worked.
        [DataType(DataType.Date)]
        public DateOnly ReleaseDate { get; set; }
        //public DateTime ReleaseDate {
        //    get
        //    {
        //        return _releaseDate;
        //    }
        //    set
        //    {
        //        _releaseDate = Convert.ToDateTime(DateOnly.FromDateTime(value));
        //    }
        //}
        public string? Genre { get; set; }
        public decimal Price { get; set; }
    }
}


