
using ChocoLux.Entities.BaseEntities;

namespace ChocoLux.Entities
{
    public class Testimonial : BaseEntity
    {
        public string Description { get; set; } = null!;
        public string Image { get; set; } = null!;
        public string Name { get; set; } = null!;
    }
}
