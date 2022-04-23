namespace Jurnal08_1302200022
{
    public class Movie
    {
        public string title { get; set; }
        public string director { get; set; }
        public string description { get; set; }

        public Movie(string title, string director, string description)
        {
            this.title = title;
            this.director = director;
            this.description = description;
        }
    }
}
