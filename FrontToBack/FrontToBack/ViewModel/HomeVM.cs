using FrontToBack.Models;

namespace FrontToBack.ViewModel
{
    public class HomeVM
    {
        public IEnumerable<SliderInfo> SliderInfos { get; set; }

        public Service Services { get; set; }

        public IEnumerable<RecentWork> RecentWorks { get; set; }

        public IEnumerable<Category> Categories { get; set; }
        public IEnumerable<Work> Works { get; set; }


    }
}
