namespace FrontToBack.Models
{
    public class Package:BaseEntity
    {
        public string Name { get; set; }

        public string Price { get; set; }

        public ICollection<Offer> Offers { get; set; }
    }
}
