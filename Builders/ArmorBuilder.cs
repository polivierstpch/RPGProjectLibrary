using RPGProjectLibrary.Models.Armor;

namespace RPGProjectLibrary.Builders
{
    public class ArmorBuilder : BaseItemBuilder<Armor, ArmorBuilder>
    {
        private ArmorCategory _category = ArmorCategory.Light;
        private int _armorClass;
        private int _arcaneSpellFailure;
        private int _skillCheckPenalty;
        private int _maxDexBonus;
        private int _bonusArmor;
        private int _speed;

        public ArmorBuilder WithCategory(ArmorCategory category)
        {
            _category = category;
            return this;
        }

        public ArmorBuilder WithArmorClass(int armorClass)
        {
            _armorClass = armorClass >= 0 ? armorClass : 0;
            return this;
        }

        public ArmorBuilder WithArcaneSpellFailure(int arcaneSpellFailure)
        {
            const int maxArcaneSpellFailure = 100;
            if (arcaneSpellFailure > 100)
                _arcaneSpellFailure = maxArcaneSpellFailure;
            else if (arcaneSpellFailure < 0)
                _arcaneSpellFailure = 0;
            else
                _arcaneSpellFailure = arcaneSpellFailure;
            return this;
        }

        public ArmorBuilder WithSkillCheckPenalty(int skillCheckPenalty)
        {
            _skillCheckPenalty = skillCheckPenalty <= 0 ? skillCheckPenalty : 0;
            return this;
        }

        public ArmorBuilder WithMaxDexBonus(int maxDexBonus)
        {
            _maxDexBonus = maxDexBonus >= 0 ? maxDexBonus : 0;
            return this;
        }

        public ArmorBuilder WithBonusArmor(int bonusArmor)
        {
            _bonusArmor = bonusArmor >= 0 ? bonusArmor : 0;
            return this;
        }

        public ArmorBuilder WithSpeed(int speed)
        {
            const int minSpeed = 15;
            _speed = speed >= minSpeed ? speed : minSpeed;
            return this;
        }

        protected override Armor Build() => new Armor
        {
            Name = Name,
            Description = Description,
            GoldValue = GoldValue,
            Category = _category,
            Properties = Properties,
            ArmorClass = _armorClass,
            ArcaneSpellFailure = _arcaneSpellFailure,
            SkillCheckPenalty = _skillCheckPenalty,
            MaxDexBonus = _maxDexBonus,
            BonusArmorClass = _bonusArmor,
            Speed = _speed
        };
    }
}