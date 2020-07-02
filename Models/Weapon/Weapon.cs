using System.Collections.Generic;
using RPGProjectLibrary.Helpers;

namespace RPGProjectLibrary.Models.Weapon
{
    public class Weapon : BaseItem
    {
        public WeaponCategory Category { get; set; }
        public int Range { get; set; }
        public int MinDamage { get; set; }
        public int MaxDamage { get; set; }
        public int CriticalRange { get; set; }
        public int CriticalMultiplier { get; set; }
        public int BonusDamage { get; set; }
        public int BonusToHit { get; set; }

        public override string ToJsonString()
        {
            return base.ToJsonString() +
                   $",\"category\":\"{Category.ToString().ToLower()}\"," +
                   $"\"range\":{Range}," +
                   $"\"minDamage\":{MinDamage}," +
                   $"\"maxDamage\":{MaxDamage}," +
                   $"\"criticalRange\":{CriticalRange}," +
                   $"\"criticalMultiplier\":{CriticalMultiplier}," +
                   $"\"bonusDamage\":{BonusDamage}," +
                   $"\"bonusToHit\":{BonusToHit}}}";
        }
    }
}
