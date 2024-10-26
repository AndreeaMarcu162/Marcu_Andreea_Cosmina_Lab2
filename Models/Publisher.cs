namespace Marcu_Andreea_Cosmina_Lab2.Models
{
    public class Publisher
    {
        public int ID { get; set; }
        public string PublisherName { get; set; }
        public ICollection<Book>? Books { get; set; } // navigation property
    }

    public static List<Publisher> GetInitialPublishers()
    {
        return new List<Publisher>
        {
            new Publishers { Id = 1, Name = "Humanitas" },
            new Publishers { Id = 2, Name = "Nemira" },
            new Publishers { Id = 3, Name = "Arthur" }
        };
    }
}
