
using ChocoLux.Entities.BaseEntities;

namespace ChocoLux.Entities
{
    public class Chocolate : BaseEntity
    {
        public string Description { get; set; } = null!;
        public string Image { get; set; } = null!;
        public string Name { get; set; } = null!;
        public int PositionId { get; set; }
        public Position Position { get; set; } = null!;
    }
}
