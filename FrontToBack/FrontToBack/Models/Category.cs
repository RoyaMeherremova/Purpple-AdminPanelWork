namespace FrontToBack.Models
{
    public class Category: BaseEntity
    {
        public string? Name { get; set; }
      

        public string? Filter { get; set; }

        public ICollection<Work> Works { get; set; }
    }


}
