
using ChocoLux.Entities.BaseEntities;

namespace ChocoLux.Entities
{
    public class Position : BaseEntity
    {
        public double Price { get; set; }
        public HashSet<Chocolate> Chocolates { get; set;}

        public Position()
        {
            Chocolates = new HashSet<Chocolate>();
        }
    }
}
