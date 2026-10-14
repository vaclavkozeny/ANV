using System;
using Cafe.enums;

namespace Cafe.drinks;

public class CustomDrink
{
    private DrinkType _base;
    private bool _sugar;
    private bool _milk;
    private bool _caramel;

    private CustomDrink(Builder b)
    {
        _base = b.BaseDrink;
        _sugar = b.HasSugar;
        _milk = b.HasMilk;
        _caramel = b.HasCaramel;
    }
    public override string ToString()
    {
        return new DrinkFactory().CreateDrink(_base).Serve()
               + (_milk ? ", milk" : "")
               + (_sugar ? ", sugar" : "")
               + (_caramel ? ", caramel" : "");
    }
    public class Builder
    {
        internal DrinkType BaseDrink { get; }
        internal bool HasMilk { get; private set; }
        internal bool HasSugar { get; private set; }
        internal bool HasCaramel { get; private set; }
        public Builder(DrinkType baseDrink)
        {
            BaseDrink = baseDrink;
        }
        public Builder Milk()
        {
            HasMilk = true;
            return this;
        }
        public Builder Sugar()
        {
            HasSugar = true;
            return this;
        }
        public Builder Caramel()
        {
            HasCaramel = true;
            return this;
        }
        public CustomDrink Build() => new CustomDrink(this);
    }
}
