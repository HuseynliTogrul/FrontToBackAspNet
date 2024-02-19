
using ChocoLux.Entities.BaseEntities;

namespace ChocoLux.Entities
{
    public class Setting : BaseEntity
    {
        public string AboutDesc { get; set; } = null!;
        public string AboutImage { get; set; } = null!;
        public string AboutName { get; set; } = null!;
        public string AboutTitle { get; set; } = null!;
        public string Number { get; set; } = null!;
        public string Email { get; set; } = null!;
    }
}
