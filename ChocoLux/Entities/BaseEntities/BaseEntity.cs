﻿
namespace ChocoLux.Entities.BaseEntities
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public bool isDeleted { get; set; }
    }
}
