namespace FrontToBack.Models
{
    public class Offer:BaseEntity
    {
        public string Key { get; set; }
       
        public int PackageId { get; set; }

        public Package Package { get; set; }

    }
}
