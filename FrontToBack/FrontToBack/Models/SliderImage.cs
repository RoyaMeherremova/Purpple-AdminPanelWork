namespace FrontToBack.Models
{
    public class SliderImage : BaseEntity
    {
        public string? Image { get; set; }

        public ICollection<SliderInfo> SliderInfos { get; set; }
    }
}
