namespace FrontToBack.Models
{
    public class SliderInfo : BaseEntity
    {
        public string? Header { get; set; }
        public string? Description { get; set; }
        public int SliderImageId { get; set; }

        public string IsActive { get; set; }
        public SliderImage SliderImage { get; set; }
    }
}
