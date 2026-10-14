using System;
using Cafe.drinks;
using Cafe.enums;

namespace Cafe;

public class DrinkFactory
{
    public IDrink CreateDrink(DrinkType d)
    {
        return d switch
        {
            DrinkType.Tea => new Tea(),
            DrinkType.Coffe => new Coffe(),
            _ => throw new ArgumentOutOfRangeException(nameof(d), d, "Unknown drink type")
        };
    }
}
