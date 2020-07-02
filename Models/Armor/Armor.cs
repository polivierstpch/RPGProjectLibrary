using System.Collections.Generic;
using RPGProjectLibrary.Helpers;

namespace RPGProjectLibrary.Models.Armor
{
    public class Armor : BaseItem
    {
        public ArmorCategory Category { get; set; }
        public int ArmorClass { get; set; }
        public int ArcaneSpellFailure { get; set; }
        public int SkillCheckPenalty { get; set; }
        public int MaxDexBonus { get; set; }
        public int Speed { get; set; }
        public int BonusArmorClass { get; set; }

        public override string ToJsonString()
        {
            return base.ToJsonString() +
                   $",\"category\":\"{Category.ToString().ToLower()}\"," +
                   $"\"armorClass\":{ArmorClass}," +
                   $"\"arcaneSpellFailure\":{ArcaneSpellFailure}," +
                   $"\"skillCheckPenalty\":{SkillCheckPenalty}," +
                   $"\"maxDexBonus\":{MaxDexBonus}," +
                   $"\"speed\":{Speed}," +
                   $"\"bonusArmorClass\":{BonusArmorClass}}}";
        }
    }
}