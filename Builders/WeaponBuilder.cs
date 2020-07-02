using RPGProjectLibrary.Models.Weapon;

namespace RPGProjectLibrary.Builders
{
    public class WeaponBuilder : BaseItemBuilder<Weapon, WeaponBuilder>
    {
        private WeaponCategory _category = WeaponCategory.Simple;
        private int _range = 5;
        private int _minDamage = 1;
        private int _maxDamage = 3;
        private int _criticalRange = 20;
        private int _criticalMultiplier = 2;
        private int _bonusDamage;
        private int _bonusToHit;

        public WeaponBuilder AsCategory(WeaponCategory category)
        {
            _category = category;
            return this;
        }

        public WeaponBuilder WithRange(int range)
        {
            const int minRange = 5;
            _range = range >= minRange ? range : minRange;
            return this;
        }

        public WeaponBuilder WithDamage(int minDamage, int maxDamage)
        {
            const int minPossibleDamage = 1;
            _minDamage = minDamage >= minPossibleDamage ? minDamage : minPossibleDamage;
            _maxDamage = maxDamage > minDamage ? maxDamage : minDamage;
            return this;
        }

        public WeaponBuilder WithCriticalRange(int criticalRange)
        {
            const int maxCriticalRange = 20;
            _criticalRange = criticalRange > 0 && criticalRange <= maxCriticalRange ? criticalRange : 20;
            return this;
        }

        public WeaponBuilder WithCriticalMultiplier(int criticalMultiplier)
        {
            const int maxCriticalMultiplier = 4;
            _criticalMultiplier = criticalMultiplier >= 2 && criticalMultiplier <= maxCriticalMultiplier ? criticalMultiplier : 2;
            return this;
        }


        public WeaponBuilder WithBonusValues(int bonusDamage, int bonusToHit)
        {
            _bonusDamage = bonusDamage >= 0 ? bonusDamage : 0;
            _bonusToHit = bonusToHit >= 0 ? bonusToHit : 0;
            return this;
        }
        
        public WeaponBuilder WithBonusValues(int bonusValue)
        {
            if( bonusValue >= 0)
            {
                _bonusDamage = bonusValue;
                _bonusToHit = bonusValue;   
            }
            return this;
        }

        protected override Weapon Build() => new Weapon
        {
            Name = Name,
            Description = Description,
            GoldValue = GoldValue,
            Properties = Properties,
            Category = _category,
            Range = _range,
            MinDamage = _minDamage,
            MaxDamage = _maxDamage,
            CriticalRange = _criticalRange,
            CriticalMultiplier = _criticalMultiplier,
            BonusDamage = _bonusDamage,
            BonusToHit = _bonusToHit
        };

    }

}