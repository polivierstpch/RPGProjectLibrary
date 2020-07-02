using System.Collections.Generic;
using System.Linq;
using RPGProjectLibrary.Models;

namespace RPGProjectLibrary.Builders
{
    public abstract class BaseItemBuilder<TItem, TBuilder> 
        where TItem : BaseItem 
        where TBuilder : BaseItemBuilder<TItem, TBuilder>
    {
        private readonly TBuilder _builderInstance;
        protected string Name { get; private set; } = "New Item";

        protected HashSet<ItemProperty> Properties { get; private set; }
        protected string Description { get; private set; } = "This is a new item.";
        protected int GoldValue { get; private set; }

        protected BaseItemBuilder()
        {
            _builderInstance = (TBuilder)this;
        }

        public TBuilder WithName(string name) 
        {
            Name = name;
            return _builderInstance;
        }
        public TBuilder WithDescription(string description) 
        {
            Description = description;
            return _builderInstance;
        }
        public TBuilder WithGoldValue(int goldValue)
        {
            GoldValue = GoldValue >= 0 ? goldValue : 0;

            return _builderInstance;
        }

        public TBuilder WithProperties(params ItemProperty[] properties)
        {
            Properties = properties.ToHashSet();
            
            return _builderInstance;
        }

        protected abstract TItem Build();

        public static implicit operator TItem(BaseItemBuilder<TItem, TBuilder> itemBuilder) =>
            itemBuilder.Build();
    }
}