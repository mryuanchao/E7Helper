using Data.Enum;
using System;

namespace Data.Models
{
    public class Equipment
    {
        public int ID { get; set; }
        public int Attack { get; set; }
        public int Defence { get; set; }
        public int CriticalRate { get; set; }
        public int CriticalDamage { get; set; }
        public int AttackPercentage { get; set; }
        public int DefencePercentage { get; set; }
        public int HitPoint { get; set; }
        public int HitPointPercentage { get; set; }
        public int Effectiveness { get; set; }
        public int Resistence { get; set; }
        public int EquipmentLv { get; set; }
        public int EnhancementLv { get; set; }
        public GearPosition Position { get; set; }
        public Set ItemSet { get; set; }
        public int? ImageID { get; set; }
    }
}
